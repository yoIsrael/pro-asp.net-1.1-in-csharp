using System.Diagnostics;
using System.Xml.Serialization;
using System;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Web.Services;

namespace WindowsClientCustomDataClass.localhost
{
	public class EmployeeDetails
	{
		private int employeeID;
		private string firstName;
		private string lastName;
		private string titleOfCourtesy;

		[XmlAttribute("id")]
		public int EmployeeID
		{
			get {return employeeID;}
			set {employeeID = value;}
		}

		[XmlElement("First")]
		public string FirstName
		{
			get {return firstName;}
			set {firstName = value;}
		}

		[XmlElement("Last")]
		public string LastName
		{
			get {return lastName;}
			set {lastName = value;}
		}

		[XmlAttribute("Title")]
		public string TitleOfCourtesy
		{
			get {return titleOfCourtesy;}
			set {titleOfCourtesy = value;}
		}

		public EmployeeDetails(int employeeID, string firstName, string lastName,
			string titleOfCourtesy)
		{
			this.employeeID = employeeID;
			this.firstName = firstName;
			this.lastName = lastName;
			this.titleOfCourtesy = titleOfCourtesy;
		}

		public EmployeeDetails(){}
	}

}
