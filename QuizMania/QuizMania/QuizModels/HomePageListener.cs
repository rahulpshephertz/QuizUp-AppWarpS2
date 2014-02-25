using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizMania.QuizModels
{
    public interface HomePageListener
    {
        void ClosePopup();
        void StartQuiz();
        void DisconnectCallback();
        void FBFriendList(List<FBFriend> fbFriendList);
    }
}
