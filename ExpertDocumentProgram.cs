using System;
using System.Reflection.Metadata;

namespace InheritenceMethod
{
	public class ExpertDocumentProgram : ProDocumentProgram
	{
		public ExpertDocumentProgram(string b, string p, string e) : base(b, p, e)
		{
        }
        public string OpenDocument()
        {
            return "Document Opened";
        }
        public override string EditDocument()
        {
            return base.EditDocument();
        }
        public override string SaveDocument()
        {
            return "Document Saved in pdf format";
        }
    }
}

