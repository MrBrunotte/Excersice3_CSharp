using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism3._4
{
    public class TextInputError : UserError
    {

        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric field only. This fired an error!";
        }
    }
}
