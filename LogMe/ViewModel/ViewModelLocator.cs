using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using LogMe.Services;
using LogMe.Services.Interface;

namespace LogMe.ViewModel
{
    public class ViewModelLocator
    {
        IIoC _ioc;

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            _ioc = new IoC();
            _ioc.Reg<MainViewModel>();
        }

        public MainViewModel Main
        {
            get => _ioc.GI<MainViewModel>();
        }
    }
}
