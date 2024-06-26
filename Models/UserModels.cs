namespace User.Models;

public class UserModel {
	public virtual int userId { get { return userId; } set { userId = value; } }
	public virtual string userName { get { return userName; } set { userName = value; } }
	public virtual string userEmail { get { return userEmail; } set { userEmail = value; } }
}
