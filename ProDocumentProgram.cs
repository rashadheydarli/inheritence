using System;
namespace InheritenceMethod
{
	public class ProDocumentProgram : DocumentProgram
	{
		public ProDocumentProgram(string b, string p, string e): base( b, p, e)
		{

		}
		public  string OpenDocument()
		{
			return "Document Opened ";
        }
        public override string EditDocument()
        {
            return "Document Edited";
        }
        public override string SaveDocument()
        {
            return "Document Saved in doc format, for pdf format buy Expert packet";
        }

    }
}

