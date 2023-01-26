using System;
namespace InheritenceMethod
{
	public class DocumentProgram
	{
		public string basic;
		public string pro;
		public string expert;

		public DocumentProgram(string b, string p, string e )
		{
			basic = b;
			pro = p;
			expert = e;
		}

		public string OpenDocument()
		{
			return "Document Opened";
		}
		public virtual string EditDocument()
		{
			return "Can Edit in Pro and Expert versions";
        }
		public virtual string SaveDocument()
		{
			return "Can Save in Pro and Expert versions";
        }
	}
}

