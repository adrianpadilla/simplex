using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Simplex
{
    public class ExpressionBuilder
    {
        public ExpressionBuilder StartOfLine
        {
            get { return this; }
        }

        public ExpressionBuilder StartOfString
        {
            get { return this; }
        }

        public ExpressionBuilder EndOfLine
        {
            get { return this; }
        }

        public ExpressionBuilder StartOfWord
        {
            get { return this; }
        }

        public ExpressionBuilder EndOfWord
        {
            get { return this; }
        }

        public ExpressionBuilder Number()
        {

            return this;
        }
        public ExpressionBuilder Number(Action<NumberDefinition> definition)
        {

            return this;
        }

        public ExpressionBuilder Char(char @char)
        {
            return this;
        }

        public ExpressionBuilder AnyOfThese(string[] options)
        {
            return this;
        }

        public ExpressionBuilder StringLiteral(string literal)
        {
            return this;
        }

        public ExpressionBuilder Word(Action<WordDefinition> definition)
        {
            return this;
        }

        public void Finish()
        {
            
        }
    }
}
