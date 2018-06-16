﻿using System.Threading.Tasks;
using Caliburn.Micro.Xamarin.Forms;

namespace LogoFX.Client.Bootstrapping.Xamarin.Forms
{
    /// <summary>
    /// An extension of <see cref="INavigationService"/> which allows navigating to view model instances
    /// </summary>
    public interface ILogoFXNavigationService : INavigationService
    {
        /// <summary>
        /// Navigates to an existing view model instance.
        /// </summary>
        /// <typeparam name="TViewModel">The type of the view model.</typeparam>
        /// <param name="viewModel">The view model instance.</param>
        /// <param name="animated">True, if the navigation should be animated, false otherwise.</param>
        /// <returns></returns>
        Task NavigateToViewModelInstanceAsync<TViewModel>(TViewModel viewModel, bool animated = true);
    }
}