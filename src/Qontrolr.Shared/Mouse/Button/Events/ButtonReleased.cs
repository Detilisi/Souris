﻿namespace Qontrolr.Shared.Mouse.Button.Events;

public class ButtonReleased : DeviceEvent<ButtonId>
{
    public ButtonReleased(ButtonId data) : base("mouse.button.released", data)
    {
    }
}
