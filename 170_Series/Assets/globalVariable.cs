using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global
{
    public static int newspaperState = 0;
    // 0: nothing
    // 1: newspaper opened, and phone not notified.
    // 2: phone sound notified
    // 3: phone opened

    public static int ticketState = 0;
    // 0: nothing
    // 1: ticket opened, and phone not notified.
    // 2: phone sound notified
    // 3: phone opened

    public static int person1ChatState = 0;
    // 0: nothing
    // 1: person1 chat clicked

    public static int person2ChatState = 0;
    // 0: nothing
    // 1: person2 chat clicked

    public static int clockState = 0;
    // 0: nothing
    // 1: clock icon clicked
    // 2: clock opened and moved
    // 3: img opened automatically

    // For Scene 2 !!!!!!!

    public static int marriageCertificateState = 0;
    // 0: nothing
    // 1: opened
    // 2: phone opened

    public static int clockStateS2 = 0;
    // 0: nothing
    // 1: after move to the right time
    // 2: img opened automatically

    public static int PuzzleState = 0;
    // 0: nothing
    // 1: done

    public static int person1ChatStateS2 = 0;
    // 0: nothing
    // 1: person1 chat clicked

}