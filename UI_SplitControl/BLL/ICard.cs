using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI_SplitControl.BLL
{
    interface ICard
    {
        string ReadCardId();
        string ReadDefaltCardId();
        void IniCard(string card_id);
        void IniNewCard(string card_id);

    }
}
