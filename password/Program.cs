string password = "123";// Create a password
string hashedPassword=BCrypt.Net.BCrypt.EnhancedHashPassword(password);// Hash the password
Console.WriteLine(hashedPassword);

bool verify=BCrypt.Net.BCrypt.EnhancedVerify(password,hashedPassword);// Verify the password matches its hash
Console.WriteLine(verify);

string savingPin = "$2a$11$gORzJST6d/2Nho6ayXL9lebybJebVbjsbrA5oL5eDumCKlob4XPV.";
Console.WriteLine(BCrypt.Net.BCrypt.EnhancedVerify(password,savingPin));
