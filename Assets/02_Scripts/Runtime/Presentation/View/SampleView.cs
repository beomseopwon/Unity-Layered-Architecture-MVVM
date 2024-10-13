using TMPro;
using UnityEngine;
using UnityEngine.UI;
using R3;
using VContainer;

namespace Company.ProjectA.Presentation
{
    public sealed class SampleView : MonoBehaviour
    {
        public Button Button;
        public TextMeshProUGUI Text;

        private SampleViewModel _viewModel;

        [Inject]
        public void Construct(SampleViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.Data.Subscribe(x => { Text.text = x; }).AddTo(this);
        }

        private void Start()
        {
            Button.OnClickAsObservable().TakeUntil(destroyCancellationToken).Subscribe(x =>
            {
                _viewModel.GetData();
            });
        }
    }
}
