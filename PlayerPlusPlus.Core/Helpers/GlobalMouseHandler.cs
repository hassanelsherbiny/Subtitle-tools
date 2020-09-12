﻿using System.Windows.Forms;

public delegate void MouseMovedEvent();

public class GlobalMouseHandler : IMessageFilter
{
    private const int WM_MOUSEMOVE = 0x0200;

    public event MouseMovedEvent TheMouseMoved;

    #region IMessageFilter Members

    public bool PreFilterMessage(ref Message m)
    {
        if (m.Msg == WM_MOUSEMOVE)
        {
            if (TheMouseMoved != null)
            {
                TheMouseMoved();
            }
        }
        // Always allow message to continue to the next filter control
        return false;
    }

    #endregion
}