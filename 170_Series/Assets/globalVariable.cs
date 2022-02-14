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
}