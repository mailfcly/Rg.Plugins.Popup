﻿using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;

namespace Rg.Plugins.Popup.Contracts
{
    internal interface IPopupPlatform
    {
        Task AddAsync(PopupPage page);

        Task RemoveAsync(PopupPage page);
    }
}