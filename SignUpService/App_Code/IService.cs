using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
		[OperationContract]
		string Insert(InsertUser user);
		// TODO: Add your service operations here
}

	// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class InsertUser
{

		string name = string.Empty;
		string email = string.Empty;
	    string pass = string.Empty;
	    string mobile = string.Empty;
	    string address = string.Empty;
	    string date= string.Empty;

	[DataMember]
	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	[DataMember]
	public string Email
	{
		get { return email; }
		set { email = value; }
	}
	[DataMember]
	public string Password
	{
		get { return pass; }
		set { pass = value; }
	}
	[DataMember]
	public string Mobile
	{
		get { return mobile; }
		set { mobile = value; }
	}
	[DataMember]
	public string Address
	{
		get { return address; }
		set { address = value; }
	}
	[DataMember]
	public string CreatedDate
	{
		get { return date; }
		set { date = value; }
	}



}

