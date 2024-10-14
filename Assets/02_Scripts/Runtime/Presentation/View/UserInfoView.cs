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
        public TextMeshProUGUI Text;

        private UserViewModel _viewModel;

        [Inject]
        public void Construct(UserViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.UserData.Where(x=> x != null).TakeUntil(destroyCancellationToken).Subscribe(x=> UpdateView() );
        }

        private void UpdateView()
        {
            Text.text = $"Id : {_viewModel.UserData.Value.Id}\n";
            Text.text += $"Name : {_viewModel.UserData.Value.Name}\n";
            Text.text += $"Email : {_viewModel.UserData.Value.Email}";
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
