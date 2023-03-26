using AutoMapper;
using LayerArchitectureSample.MVVM.Models;
using LayerArchitectureSample.Service.Dtos;
using LayerArchitectureSample.Service.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace LayerArchitectureSample.MVVM.ViewModels
{
    public class FooViewModel : ViewModelBase
    {
        private IFooService _fooService;
        private IMapper _mapper;

        public FooViewModel(IFooService fooService, IMapper mapper)
        {
            _fooService = fooService;
            _mapper = mapper;

            GetFoos().ConfigureAwait(false);
        }

        public async Task GetFoos()
        {
            Foos = new ObservableCollection<FooModel>(await GetAsync(new QueryFooModel { Id = 1, Key = "Machine3" }));
        }

        private ObservableCollection<FooModel> _foos;

        public ObservableCollection<FooModel> Foos
        {
            get => _foos;
            set
            {
                _foos = value;
                NotifyPropertyChanged();
            }
        }

        public async Task<IEnumerable<FooModel>> GetAsync(QueryFooModel parameter)
        {
            // Convert FooParameter to QuryFooDto
            var queryFooDto = _mapper.Map<QueryFooDto>(parameter);

            var fooDto = await _fooService.GetAsync(queryFooDto);

            // Convert FooDto to FooModel
            var fooModels = _mapper.Map<IEnumerable<FooModel>>(fooDto);

            return fooModels;
        }
    }
}
