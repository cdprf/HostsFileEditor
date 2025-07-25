﻿// <copyright file="MenuStripEx.cs" company="N/A">
// Copyright 2025 Scott M. Lerch
// 
// This file is part of HostsFileEditor.
// 
// HostsFileEditor is free software: you can redistribute it and/or modify it 
// under the terms of the GNU General Public License as published by the Free 
// Software Foundation, either version 2 of the License, or (at your option)
// any later version.
// 
// HostsFileEditor is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
// more details.
// 
// You should have received a copy of the GNU General Public   License along
// with HostsFileEditor. If not, see http://www.gnu.org/licenses/.
// </copyright>

using System.ComponentModel;

namespace HostsFileEditor.Controls;

/// <summary>
/// This class adds on to the functionality provided in 
/// System.Windows.Forms.MenuStrip.
/// </summary>
/// <remarks>
/// Click through feature from:
/// http://blogs.msdn.com/b/rickbrew/archive/2006/01/09/511003.aspx
/// </remarks>
internal class MenuStripEx : MenuStrip
{
    /// <summary>
    /// Gets or sets whether the MenuStripEx honors item clicks when 
    /// its containing form does not have input focus.
    /// </summary>
    /// <remarks>
    /// Default value is false, which is the same behavior provided by
    /// the base MenuStrip class.
    /// </remarks>
    [DefaultValue(false)]
    public bool ClickThrough { get; set; }

    /// <inheritdoc />
    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        if (ClickThrough &&
            m.Msg == NativeConstants.WM_MOUSEACTIVATE &&
            m.Result == (IntPtr)NativeConstants.MA_ACTIVATEANDEAT)
        {
            m.Result = (IntPtr)NativeConstants.MA_ACTIVATE;
        }
    }

    /// <summary>
    /// Native constants needed by WndProc.
    /// </summary>
    private static class NativeConstants
    {
        internal const uint WM_MOUSEACTIVATE = 0x21;
        internal const uint MA_ACTIVATE = 1;
        internal const uint MA_ACTIVATEANDEAT = 2;
        internal const uint MA_NOACTIVATE = 3;
        internal const uint MA_NOACTIVATEANDEAT = 4;
    }
}
