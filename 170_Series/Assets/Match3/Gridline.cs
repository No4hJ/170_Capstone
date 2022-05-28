using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridline : MonoBehaviour
{
    public enum PieceType
    {
        EMPTY,
        NORMAL,
        BUBBLE,
        COUNT,
    };

    [System.Serializable]
    public struct PiecePrefab{

        public PieceType type;
        public GameObject prefab;
    }

    public int xDim;
    public int yDim;
    public float fillTime;
    private bool inverse = false;

    public level level;

    private GamePiece pressedPiece;
    private GamePiece enteredPiece;
    public PiecePrefab[] piecePrefabs;
    public GameObject background;

    private bool gameOver = false;

    private Dictionary<PieceType, GameObject> piecePrefabDict;

    private GamePiece [,] pieces;
    // Start is called before the first frame update
    void Start()
    {
        piecePrefabDict = new Dictionary<PieceType, GameObject>();
        for(int i = 0; i < piecePrefabs.Length; i++){
            if(!piecePrefabDict.ContainsKey(piecePrefabs[i].type)){
                piecePrefabDict.Add(piecePrefabs [i].type, piecePrefabs[i].prefab);
            }
        }

        for(int x = 0; x <xDim; x++){
            for(int y = 0; y < yDim; y++){
                GameObject backgroundobj = (GameObject)Instantiate(background, GetWorldPosition(x,y), Quaternion.identity);
                backgroundobj.transform.parent = transform;
            }
        }

        pieces = new GamePiece [xDim, yDim];
        for (int x = 0; x < xDim; x++){
            for(int y = 0; y < yDim; y++){
                SpawnNewPiece(x,y, PieceType.EMPTY);
            }
        }


        StartCoroutine(Fill());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Fill(){
        //Debug.Log("fill");

        bool needsRefil = true;
        while (needsRefil)
        {
            yield return new WaitForSeconds(fillTime);
            while(FillStep()){

                inverse = !inverse;
                yield return new WaitForSeconds(fillTime);
            }

            needsRefil = ClearAllValidMatches();
        }
        
    }

    public bool FillStep(){
        bool movedPiece = false;

        for(int y = yDim-2; y >= 0; y--){
            for(int loopX = 0; loopX < xDim; loopX++){
                int x = loopX;

                if(inverse){
                    x = xDim - 1 - loopX;
                }

                GamePiece piece = pieces[x,y];

                if(piece.IsMovable()){
                    GamePiece pieceBelow = pieces[x,y+1];

                    if(pieceBelow.Type == PieceType.EMPTY){
                        piece.MovableComponent.Move(x,y+1, fillTime);
                        pieces [x,y+1] = piece;
                        SpawnNewPiece(x,y,PieceType.EMPTY);
                        movedPiece = true;
                    }else{
                        for(int diag = -1 ; diag <= 1; diag++){
                            if(diag != 0){
                                int diagX = x + diag;

                                if(inverse){ diagX = x - diag;}

                                if(diagX >0 && diagX < xDim){
                                    GamePiece diagonalPiece = pieces [diagX, y+1];
                                    if(diagonalPiece.Type == PieceType.EMPTY){
                                        bool hasPieceAbove = true;
                                        for(int aboveY = y; aboveY >= 0 ; aboveY --){
                                            GamePiece pieceAbove = pieces[diagX,aboveY];
                                            if(pieceAbove.IsMovable()){
                                                break;
                                            }else if(!pieceAbove.IsMovable()&& pieceAbove.Type != PieceType.EMPTY){
                                                hasPieceAbove = false;
                                                break;
                                            }
                                        }
                                        if(!hasPieceAbove){
                                            Destroy(diagonalPiece.gameObject);
                                            piece.MovableComponent.Move(diagX, y+1, fillTime);
                                            pieces[diagX, y + 1] = piece;
                                            SpawnNewPiece(x,y,PieceType.EMPTY);
                                            movedPiece = true;
                                            break;
                                        }


                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        for(int x = 0; x < xDim; x++){
            GamePiece pieceBelow = pieces[x,0];

            if(pieceBelow.Type == PieceType.EMPTY){
                GameObject newPiece = (GameObject)Instantiate(piecePrefabDict[PieceType.NORMAL], GetWorldPosition(x, -1),
                    Quaternion.identity);
                newPiece.transform.parent = transform;

                pieces[x,0] = newPiece.GetComponent<GamePiece>();
                pieces[x,0].Init(x,-1,this,PieceType.NORMAL);
                pieces[x,0].MovableComponent.Move(x,0, fillTime);
                pieces[x,0].ColorComponent.SetColor((ColorPiece.ColorType)Random.Range(0,pieces[x,0].ColorComponent.NumColors));
                movedPiece = true;
            }
        }
        return movedPiece;
    }

    public Vector2 GetWorldPosition(int x, int y){

        
        return new Vector2(transform.position.x - xDim/2.0f + x , transform.position.y + yDim/2.0f - y);
    }

    public GamePiece SpawnNewPiece(int x, int y, PieceType type){
        
        GameObject newPiece = (GameObject)Instantiate(piecePrefabDict [type], GetWorldPosition(x,y), Quaternion.identity, this.transform);
        newPiece.transform.parent = transform;

        pieces [x,y] = newPiece.GetComponent<GamePiece>();
        pieces [x,y].Init(x,y, this ,type);
        return pieces [x,y];

    }


    public bool IsAdjacent(GamePiece piece1, GamePiece piece2){
        return(piece1.X == piece2.X && (int)Mathf.Abs(piece1.Y- piece2.Y) == 1)
        ||(piece1.Y == piece2.Y && (int)Mathf.Abs(piece1.X- piece2.X) == 1);
    }

    public void SwapPieces(GamePiece piece1, GamePiece piece2){
        
        if(gameOver){
            return;
        }
        /*if(piece1.IsMovable() && piece2.IsMovable()){
            pieces [piece1.X, piece1.Y] = piece2;
            pieces [piece2.X, piece2.Y] = piece1;

            if(GetMatch(piece1, piece2.X, piece2.Y) != null || GetMatch(piece2, piece1.X,piece1.Y) != null){
                int piece1X = piece1.X;
                int piece1Y = piece1.Y;

                piece1.MovableComponent.Move(piece2.X, piece2.Y, fillTime);
                piece2.MovableComponent.Move(piece1X, piece1Y, fillTime);

                ClearAllValidMatches();
                StartCoroutine(Fill());
                
            }else{
                 pieces[piece1.X, piece1.Y] = piece1;
                 pieces[piece2.X, piece2.Y] = piece1;
            }
            
        }
        

        */


        if (!piece1.IsMovable() || !piece2.IsMovable()) return;
        
        pieces[piece1.X, piece1.Y] = piece2;
        pieces[piece2.X, piece2.Y] = piece1;

        if (GetMatch(piece1, piece2.X, piece2.Y) != null || GetMatch(piece2, piece1.X, piece1.Y) != null)
        {
            int piece1X = piece1.X;
            int piece1Y = piece1.Y;

            piece1.MovableComponent.Move(piece2.X, piece2.Y, fillTime);
            piece2.MovableComponent.Move(piece1X, piece1Y, fillTime);

            ClearAllValidMatches();


            StartCoroutine(Fill());
            level.OnMove();

            // TODO consider doing this using delegates
        }
        else
        {
            pieces[piece1.X, piece1.Y] = piece1;
            pieces[piece2.X, piece2.Y] = piece2;
        }
        
    }
    
    public void PressPiece(GamePiece piece){
        pressedPiece = piece;
    }

    public void EnterPiece(GamePiece piece){

        enteredPiece = piece;

    }

    public void ReleasePiece(){
        if(IsAdjacent (pressedPiece, enteredPiece)){
            SwapPieces(pressedPiece, enteredPiece);
        }
    }

    public List<GamePiece> GetMatch(GamePiece piece, int newX, int newY){
        
        /*
        if(piece.IsColored()){
            ColorPiece.ColorType color = piece.ColorComponent.Color;
            List<GamePiece> horizontalPieces = new List<GamePiece>();
            List<GamePiece> verticalPieces = new List<GamePiece>();
            List<GamePiece> matchingPieces = new List<GamePiece>();


            //horizontal
            horizontalPieces.Add(piece);

            for(int dir = 0; dir <= 1; dir++){
                for(int xOffset = 1; xOffset <xDim; xOffset++){
                    int x;

                    if(dir == 0){
                        x = newX - xOffset;
                    }else{
                        x = newX + xOffset;
                    }

                    if(x < 0 || x >= xDim){
                        break;
                    }

                    if(pieces [x, newY].IsColored() && pieces[x,newY].ColorComponent.Color == color){
                        horizontalPieces.Add(pieces[x, newY]);
                    }else{
                        break;
                    }
                }
            }

            if(horizontalPieces.Count >= 3){
                for(int i = 0; i<horizontalPieces.Count; i++){
                    matchingPieces.Add(horizontalPieces[i]);
                }
            }
            
            
            //T and L    
            if(horizontalPieces.Count  >= 3){
                for(int i = 0; i<horizontalPieces.Count; i++){
                    for(int dir=0; dir<= 1; dir++){
                        for(int yOffset = 1; yOffset <yDim; yOffset++){
                            int y;
                            if(dir ==0){
                                y = newY - yOffset;
                            }else{
                                y = newY + yOffset;
                            }

                            if(y<0||y>=yDim){
                                break;
                            }

                            if(pieces[horizontalPieces[i].X, y].IsColored() && pieces[horizontalPieces[i].X, y].ColorComponent.Color ==color){
                                verticalPieces.Add(pieces[horizontalPieces[i].X,y]);
                            }else{
                                break;
                            }
                        }
                    }

                    if(verticalPieces.Count < 2){
                        verticalPieces.Clear();
                    }else{
                        for(int j = 0; j < verticalPieces.Count; j++){
                            matchingPieces.Add ( verticalPieces [j]);
                        }
                        break;
                    }
                }
            }
            



            if(matchingPieces.Count >= 3){
                return matchingPieces;
            } 

            //vertical
            horizontalPieces.Clear();
            verticalPieces.Clear();
            verticalPieces.Add(piece);

            for(int dir = 0; dir <= 1; dir++){
                for(int yOffset = 1; yOffset <yDim; yOffset++){
                    int y;

                    if(dir == 0){
                        y = newY - yOffset;
                    }else{
                        y = newY + yOffset;
                    }

                    if(y < 0 || y >= yDim){
                        break;
                    }

                    if(pieces [newX, y].IsColored() && pieces[newX,y].ColorComponent.Color == color){
                        verticalPieces.Add(pieces[newX, y]);
                    }else{
                        break;
                    }
                }
            }

            if(verticalPieces.Count >= 3){
                for(int i = 0; i<verticalPieces.Count; i++){
                    matchingPieces.Add(verticalPieces[i]);
                }
            }
            
            
            //T and L    
            if(verticalPieces.Count  >= 3){
                for(int i = 0; i<verticalPieces.Count; i++){
                    for(int dir=0; dir<= 1; dir++){
                        for(int xOffset = 1; xOffset <xDim; xOffset++){
                            int x;
                            if(dir ==0){
                                x = newX - xOffset;
                            }else{
                                x = newX + xOffset;
                            }

                            if(x<0||x>=xDim){
                                break;
                            }

                            if(pieces[x, verticalPieces[i].Y].IsColored() && pieces[x, verticalPieces[i].Y].ColorComponent.Color ==color){
                                horizontalPieces.Add(pieces[x, verticalPieces[i].Y]);
                            }else{
                                break;
                            }
                        }
                    }

                    if(horizontalPieces.Count < 2){
                        horizontalPieces.Clear();
                    }else{
                        for(int j = 0; j < horizontalPieces.Count; j++){
                            matchingPieces.Add ( horizontalPieces [j]);
                        }

                        break;
                    }
                }
            }
            

            if(matchingPieces.Count >= 3){
                return matchingPieces;
            }     
            
        }

        return null;
        */
        if (!piece.IsColored()) return null;
        var color = piece.ColorComponent.Color;
        var horizontalPieces = new List<GamePiece>();
        var verticalPieces = new List<GamePiece>();
        var matchingPieces = new List<GamePiece>();

        // First check horizontal
        horizontalPieces.Add(piece);

        for (int dir = 0; dir <= 1; dir++)
        {
            for (int xOffset = 1; xOffset < xDim; xOffset++)
            {
                int x;

                if (dir == 0)
                { // Left
                    x = newX - xOffset;
                }
                else
                { // right
                    x = newX + xOffset;                        
                }

                // out-of-bounds
                if (x < 0 || x >= xDim) { break; }

                // piece is the same color?
                if (pieces[x, newY].IsColored() && pieces[x, newY].ColorComponent.Color == color)
                {
                    horizontalPieces.Add(pieces[x, newY]);
                }
                else
                {
                    break;
                }
            }
        }

        if (horizontalPieces.Count >= 3)
        {
            for (int i = 0; i < horizontalPieces.Count; i++)
            {
                matchingPieces.Add(horizontalPieces[i]);
            }
        }

        // Traverse vertically if we found a match (for L and T shape)
        if (horizontalPieces.Count >= 3)
        {
            for (int i = 0; i < horizontalPieces.Count; i++ )
            {
                for (int dir = 0; dir <= 1; dir++)
                {
                    for (int yOffset = 1; yOffset < yDim; yOffset++)                        
                    {
                        int y;
                            
                        if (dir == 0)
                        { // Up
                            y = newY - yOffset;
                        }
                        else
                        { // Down
                            y = newY + yOffset;
                        }

                        if (y < 0 || y >= yDim)
                        {
                            break;
                        }

                        if (pieces[horizontalPieces[i].X, y].IsColored() && pieces[horizontalPieces[i].X, y].ColorComponent.Color == color)
                        {
                            verticalPieces.Add(pieces[horizontalPieces[i].X, y]);
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (verticalPieces.Count < 2)
                {
                    verticalPieces.Clear();
                }
                else
                {
                    for (int j = 0; j < verticalPieces.Count; j++)
                    {
                        matchingPieces.Add(verticalPieces[j]);
                    }
                    break;
                }
            }
        }

        if (matchingPieces.Count >= 3)
        {
            return matchingPieces;
        }


        // Didn't find anything going horizontally first,
        // so now check vertically
        horizontalPieces.Clear();
        verticalPieces.Clear();
        verticalPieces.Add(piece);

        for (int dir = 0; dir <= 1; dir++)
        {
            for (int yOffset = 1; yOffset < xDim; yOffset++)
            {
                int y;

                if (dir == 0)
                { // Up
                    y = newY - yOffset;
                }
                else
                { // Down
                    y = newY + yOffset;                        
                }

                // out-of-bounds
                if (y < 0 || y >= yDim) { break; }

                // piece is the same color?
                if (pieces[newX, y].IsColored() && pieces[newX, y].ColorComponent.Color == color)
                {
                    verticalPieces.Add(pieces[newX, y]);
                }
                else
                {
                    break;
                }
            }
        }

        if (verticalPieces.Count >= 3)
        {
            for (int i = 0; i < verticalPieces.Count; i++)
            {
                matchingPieces.Add(verticalPieces[i]);
            }
        }

        // Traverse horizontally if we found a match (for L and T shape)
        if (verticalPieces.Count >= 3)
        {
            for (int i = 0; i < verticalPieces.Count; i++)
            {
                for (int dir = 0; dir <= 1; dir++)
                {
                    for (int xOffset = 1; xOffset < yDim; xOffset++)
                    {
                        int x;

                        if (dir == 0)
                        { // Left
                            x = newX - xOffset;
                        }
                        else
                        { // Right
                            x = newX + xOffset;
                        }

                        if (x < 0 || x >= xDim)
                        {
                            break;
                        }

                        if (pieces[x, verticalPieces[i].Y].IsColored() && pieces[x, verticalPieces[i].Y].ColorComponent.Color == color)
                        {
                            horizontalPieces.Add(pieces[x, verticalPieces[i].Y]);
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (horizontalPieces.Count < 2)
                {
                    horizontalPieces.Clear();
                }
                else
                {
                    for (int j = 0; j < horizontalPieces.Count; j++)
                    {
                        matchingPieces.Add(horizontalPieces[j]);
                    }
                    break;
                }
            }
        }

        if (matchingPieces.Count >= 3)
        {
            return matchingPieces;
        }

        return null;
    
    }

    
    public bool ClearAllValidMatches(){
        //Debug.Log("ClearAllValidMatches");
        bool needsRefill = false;

        for(int y = 0; y < yDim; y++){
            for(int x = 0; x < xDim; x++){
                if(pieces[x,y].IsClearable()){
                    List<GamePiece>match = GetMatch(pieces[x,y],x,y);

                    if(match != null){
                        for(int i = 0; i<match.Count; i++){
                            if(ClearPiece(match[i].X, match[i].Y)){
                                needsRefill = true;
                            }
                        }
                    }
                }
            }
        }
        return needsRefill;
    }
    public bool ClearPiece(int x, int y){
        //Debug.Log("ClearPiece");
        if(pieces[x,y].IsClearable()&& !pieces[x,y].ClearableComponent.IsBeingCleared){
            pieces[x,y].ClearableComponent.Clear();

            SpawnNewPiece(x,y,PieceType.EMPTY);
            ClearObstacles(x,y);

            return true;
        }

        return false;
    }

    public void ClearObstacles(int x, int y){
        for (int adjacentX = x - 1; adjacentX <= x + 1; adjacentX++)
        {
            if (adjacentX == x || adjacentX < 0 || adjacentX >= xDim) continue;

            if (pieces[adjacentX, y].Type != PieceType.BUBBLE || !pieces[adjacentX, y].IsClearable()) continue;
            
            pieces[adjacentX, y].ClearableComponent.Clear();
            SpawnNewPiece(adjacentX, y, PieceType.EMPTY);
        }

        for (int adjacentY = y - 1; adjacentY <= y + 1; adjacentY++)
        {
            if (adjacentY == y || adjacentY < 0 || adjacentY >= yDim) continue;

            if (pieces[x, adjacentY].Type != PieceType.BUBBLE || !pieces[x, adjacentY].IsClearable()) continue;
            
            pieces[x, adjacentY].ClearableComponent.Clear();
            SpawnNewPiece(x, adjacentY, PieceType.EMPTY);
        }
    }
    public void GameOver(){
        gameOver = true;
    }
    
}

