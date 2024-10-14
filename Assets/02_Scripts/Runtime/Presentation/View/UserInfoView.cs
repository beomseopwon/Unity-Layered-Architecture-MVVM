using TMPro;
using UnityEngine;
using UnityEngine.UI;
using R3;
using VContainer;

namespace Company.ProjectA.Presentation
{
    public sealed class UserInfoView : MonoBehaviour
    {
        public Button Button;
        public TextMeshProUGUI IdText;
        public TextMeshProUGUI NameText;
        public TextMeshProUGUI EmailText;

        private UserViewModel _viewModel;

        [Inject]
        public void Construct(UserViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.Id.TakeUntil(destroyCancellationToken).Subscribe(x => IdText.text = $"Id : {x}");
            _viewModel.Name.TakeUntil(destroyCancellationToken).Subscribe(x => NameText.text = $"Name : {x}");
            _viewModel.Email.TakeUntil(destroyCancellationToken).Subscribe(x => EmailText.text = $"Email : {x}");
        }

        private void Start()
        {
            Button.OnClickAsObservable().TakeUntil(destroyCancellationToken).Subscribe(x =>
            {
                _viewModel.GetUser(123);
            });
        }
    }
}
