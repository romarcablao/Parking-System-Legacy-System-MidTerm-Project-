using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace ParkingSystem_SoftEng
{  
    class classConnection
    {

        private string conString = "server=localhost; user=root; password=; database=parkingsystemdb_softeng";
        private MySqlConnection con = new MySqlConnection();
        private MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private MySqlDataReader rd;
        private string sql;

        public void openConnection()
        {
            con = new MySqlConnection();
            con.ConnectionString = conString;
            con.Open();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }           // Encode Base64

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }   // Decode Base64
           
        public static string Sanitize(string plainText)
        {
            string clean = Regex.Replace(plainText, "[^A-Za-z0-9 ]", "");
            return clean;
        }               // Sanitize Input

        public List<UserData> login(string username, string password)
        {
            username = Sanitize(username);
            password = Base64Encode(password);

            try
            {
                openConnection();
                sql = "SELECT * FROM tblUser WHERE BINARY userUsername='" + username + "' AND BINARY userPassword = '" + password + "'";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfPerson = new List<UserData>();
                    var count = 0;
                   
                        while (rd.Read())
                        {
                            var person = new UserData();

                            person.userID = rd["userID"].ToString();
                            person.userLname = rd["userLname"].ToString();
                            person.userFname = rd["userFname"].ToString();
                            person.userUsername = rd["userUsername"].ToString();
                            person.userPassword = rd["userPassword"].ToString();
                            person.userAccLevel = rd["userAccLevel"].ToString();
                            person.userStatus = rd["userStatus"].ToString();
                            person.created_at = rd["created_at"].ToString();
                            person.updated_at = rd["updated_at"].ToString();

                            count += 1;
                            listOfPerson.Add(person);

                        }

                    if(count == 1)
                    {
                        return listOfPerson;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF LOGIN

        public Boolean createUser(UserData passedData)
        {
            bool reqStatus = false;

            passedData.userFname = Sanitize(passedData.userFname);
            passedData.userLname = Sanitize(passedData.userLname);
            passedData.userUsername = Sanitize(passedData.userUsername);
            passedData.userPassword = Base64Encode(passedData.userPassword);

            passedData.userStatus = (passedData.userStatus == "" || passedData.userStatus == null ? "1" : passedData.userStatus);
            passedData.userAccLevel = (passedData.userAccLevel == "" || passedData.userAccLevel == null ? "GUEST" : passedData.userAccLevel);

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            passedData.created_at = date;


            try
            {
                openConnection();
                sql = @"INSERT INTO tblUser SET userLname='" + passedData.userLname +
                                       "', userFname='" + passedData.userFname +
                                       "', userPassword='" + passedData.userPassword +
                                       "', userUsername='" + passedData.userUsername +
                                       "', userStatus='" + passedData.userStatus +
                                       "', userAccLevel='" + passedData.userAccLevel +
                                       "', created_at='" + passedData.created_at + "'";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                reqStatus = true;
            }
            catch
            {
                reqStatus = false;
            }
            finally
            {
                con.Close();
            }

            return reqStatus; 
        }//END OF CREATE USER

        public Boolean updateUser(UserData passedData)
        {
            bool reqStatus = false;

            passedData.userFname = Sanitize(passedData.userFname);
            passedData.userLname = Sanitize(passedData.userLname);
            passedData.userUsername = Sanitize(passedData.userUsername);
            passedData.userPassword = Base64Encode(passedData.userPassword);

            passedData.userStatus = (passedData.userStatus == "" || passedData.userStatus == null ? "1" : passedData.userStatus);
            passedData.userAccLevel = (passedData.userAccLevel == "" || passedData.userAccLevel == null ? "GUEST" : passedData.userAccLevel);

            try
            {
                openConnection();
                sql = @"UPDATE tblUser SET userLname='" + passedData.userLname +
                                       "', userFname='" + passedData.userFname +
                                       "', userPassword='" + passedData.userPassword +
                                       "', userUsername='" + passedData.userUsername +
                                       "', userStatus='" + passedData.userStatus +
                                       "', userAccLevel='" + passedData.userAccLevel +
                                       "' WHERE userID='" + passedData.userID + "'";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                reqStatus = true;
            }
            catch
            {
                reqStatus = false;
            }
            finally
            {
                con.Close();
            }

            return reqStatus;
        }//END OF UPDATE USER

        public List<UserData> readUser_byID(string id)
        {

            try
            {
                openConnection();
                sql = "SELECT * FROM tblUser WHERE userID='" + id + "'";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                Console.WriteLine(rd.HasRows);

                if(rd.HasRows){

                    var listOfPerson = new List<UserData>();

                    while (rd.Read())
                    {

                        var person = new UserData();

                        person.userID = rd["userID"].ToString();
                        person.userLname = rd["userLname"].ToString();
                        person.userFname = rd["userFname"].ToString();
                        person.userUsername = rd["userUsername"].ToString();
                        person.userPassword = Base64Decode(rd["userPassword"].ToString());
                        person.userAccLevel = rd["userAccLevel"].ToString();
                        person.userStatus = rd["userStatus"].ToString();
                        person.created_at = rd["created_at"].ToString();
                        person.updated_at = rd["updated_at"].ToString();

                        listOfPerson.Add(person);

                    }

                    return listOfPerson;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF READ USER BY ID

        public Boolean countUser_byUsername(string username, string id)
        {
            bool reqStatus = false;
            string userID = null;
            try
            {
                openConnection();
                sql = "SELECT * FROM tblUser WHERE userUsername='" + username + "'";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                Console.WriteLine(rd.HasRows);

                if (rd.HasRows)
                {
                    var counter = 0;
                    while (rd.Read())
                    {
                        userID = rd["userID"].ToString();
                        counter++;
                    }

                    if (counter == 1 && userID == id)
                    {
                        reqStatus = true;
                    }

                }
                else
                {
                    reqStatus = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return reqStatus;

        }//END OF READ USER BY USERNAME

        public List<UserData> readUser_all()
        {

            try
            {
                openConnection();
                sql = "SELECT * FROM tbluser";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfPerson = new List<UserData>();

                    while (rd.Read())
                    {

                        var person = new UserData();

                        person.userID = rd["userID"].ToString();
                        person.userLname = rd["userLname"].ToString();
                        person.userFname = rd["userFname"].ToString();
                        person.userUsername = rd["userUsername"].ToString();
                        person.userPassword = Base64Decode(rd["userPassword"].ToString());
                        person.userAccLevel = rd["userAccLevel"].ToString();
                        person.userStatus = rd["userStatus"].ToString();
                        person.created_at = rd["created_at"].ToString();
                        person.updated_at = rd["updated_at"].ToString();

                        //DateTime timeIn = DateTime.Parse(person.created_at);
                        //DateTime timeOut = DateTime.Parse(person.updated_at);

                        //Console.WriteLine(timeOut.Subtract(timeIn).TotalHours);

                        listOfPerson.Add(person);

                    }

                    return listOfPerson;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF READ ALL USER

        public List<UserData> searchUser_all(string searchText)
        {

            searchText = Sanitize(searchText);

            try
            {
                openConnection();
                sql = @"SELECT * FROM tbluser WHERE userUsername LIKE '%" + searchText + 
                                                    "%' OR userFname LIKE '%" + searchText +
                                                    "%' OR userLname LIKE '%" + searchText +
                                                    "%' OR userAccLevel LIKE '%" + searchText +
                                                    "%' OR userStatus LIKE '%" + searchText +
                                                    "%'";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfPerson = new List<UserData>();

                    while (rd.Read())
                    {

                        var person = new UserData();

                        person.userID = rd["userID"].ToString();
                        person.userLname = rd["userLname"].ToString();
                        person.userFname = rd["userFname"].ToString();
                        person.userUsername = rd["userUsername"].ToString();
                        person.userPassword = Base64Decode(rd["userPassword"].ToString());
                        person.userAccLevel = rd["userAccLevel"].ToString();
                        person.userStatus = rd["userStatus"].ToString();
                        person.created_at = rd["created_at"].ToString();
                        person.updated_at = rd["updated_at"].ToString();

                        listOfPerson.Add(person);

                    }

                    return listOfPerson;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF SEARCH FROM ALL USER

        public Boolean createTypeRates(VehicleType passedData)
        {
            bool reqStatus = false;

            passedData.typeName = passedData.typeName;

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            passedData.created_at = date;


            try
            {
                openConnection();
                sql = @"INSERT INTO tblvehicletype SET typeName='" + passedData.typeName +
                                       "', typeRatePerHour='" + passedData.typeRatePerHour +
                                       "', created_at='" + passedData.created_at + "'";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                reqStatus = true;
            }
            catch
            {
                reqStatus = false;
            }
            finally
            {
                con.Close();
            }

            return reqStatus;
        }//END OF CREATE TYPE

        public Boolean updateTypeRates(VehicleType passedData)
        {
            bool reqStatus = false;

            passedData.typeName = passedData.typeName;

            try
            {
                openConnection();
                sql = @"UPDATE tblvehicletype SET typeName='" + passedData.typeName +
                                       "', typeRatePerHour='" + passedData.typeRatePerHour +
                                       "' WHERE typeID='" + passedData.typeID + "'";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                reqStatus = true;
            }
            catch
            {
                reqStatus = false;
            }
            finally
            {
                con.Close();
            }

            return reqStatus;
        }//END OF UPDATE TYPE

        public List<VehicleType> readTypeRates_all()
        {

            try
            {
                openConnection();
                sql = "SELECT * FROM tblvehicletype";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfType = new List<VehicleType>();

                    while (rd.Read())
                    {

                        var type = new VehicleType();

                        type.typeID = rd["typeID"].ToString();
                        type.typeName = rd["typeName"].ToString();
                        type.typeRatePerHour = rd["typeRatePerHour"].ToString();

                        type.created_at = rd["created_at"].ToString();
                        type.updated_at = rd["updated_at"].ToString();

                        //DateTime timeIn = DateTime.Parse(person.created_at);
                        //DateTime timeOut = DateTime.Parse(person.updated_at);

                        //Console.WriteLine(timeOut.Subtract(timeIn).TotalHours);

                        listOfType.Add(type);

                    }

                    return listOfType;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF READ ALL TYPE

        public List<VehicleType> searchTypeRates_all(string searchText)
        {

            searchText = Sanitize(searchText);

            try
            {
                openConnection();
                sql = @"SELECT * FROM tblvehicletype WHERE typeName LIKE '%" + searchText +
                                                    "%' OR typeRatePerHour LIKE '%" + searchText +
                                                    "%'";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfType = new List<VehicleType>();

                    while (rd.Read())
                    {

                        var type = new VehicleType();

                        type.typeID = rd["typeID"].ToString();
                        type.typeName = rd["typeName"].ToString();
                        type.typeRatePerHour = rd["typeRatePerHour"].ToString();

                        type.created_at = rd["created_at"].ToString();
                        type.updated_at = rd["updated_at"].ToString();

                        //DateTime timeIn = DateTime.Parse(person.created_at);
                        //DateTime timeOut = DateTime.Parse(person.updated_at);

                        //Console.WriteLine(timeOut.Subtract(timeIn).TotalHours);

                        listOfType.Add(type);

                    }

                    return listOfType;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF SEARCH FROM ALL TYPE

        public Boolean createBrands(VehicleBrand passedData)
        {
            bool reqStatus = false;

            passedData.brandName = passedData.brandName;
            passedData.brandCategory = passedData.brandCategory;
            passedData.brandStatus = Sanitize(passedData.brandStatus);

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            passedData.created_at = date;


            try
            {
                openConnection();
                sql = @"INSERT INTO tblvehiclebrand SET brandName='" + passedData.brandName +
                                       "', brandCategory='" + passedData.brandCategory +
                                       "', brandStatus='" + passedData.brandStatus +
                                       "', created_at='" + passedData.created_at + "'";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                reqStatus = true;
            }
            catch
            {
                reqStatus = false;
            }
            finally
            {
                con.Close();
            }

            return reqStatus;
        }//END OF CREATE BRAND

        public Boolean updateBrands(VehicleBrand passedData)
        {
            bool reqStatus = false;

            passedData.brandName = passedData.brandName;
            passedData.brandCategory = passedData.brandCategory;
            passedData.brandStatus = Sanitize(passedData.brandStatus);

            try
            {
                openConnection();
                sql = @"UPDATE tblvehiclebrand SET brandName='" + passedData.brandName +
                                      "', brandCategory='" + passedData.brandCategory +
                                      "', brandStatus='" + passedData.brandStatus +
                                       "' WHERE brandID='" + passedData.brandID + "'";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                reqStatus = true;
            }
            catch
            {
                reqStatus = false;
            }
            finally
            {
                con.Close();
            }

            return reqStatus;
        }//END OF UPDATE BRAND

        public List<VehicleBrand> readBrands_all()
        {

            try
            {
                openConnection();
                sql = "SELECT * FROM tblvehiclebrand";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfBrand = new List<VehicleBrand>();

                    while (rd.Read())
                    {

                        var brand = new VehicleBrand();

                        brand.brandID = rd["brandID"].ToString();
                        brand.brandName = rd["brandName"].ToString();
                        brand.brandCategory = rd["brandCategory"].ToString();
                        brand.brandStatus = rd["brandStatus"].ToString();

                        brand.created_at = rd["created_at"].ToString();
                        brand.updated_at = rd["updated_at"].ToString();

                        listOfBrand.Add(brand);

                    }

                    return listOfBrand;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF READ ALL BRAND

        public List<VehicleBrand> readBrands_active()
        {

            try
            {
                openConnection();
                sql = "SELECT * FROM tblvehiclebrand WHERE brandStatus='ACTIVE'";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfBrand = new List<VehicleBrand>();

                    while (rd.Read())
                    {

                        var brand = new VehicleBrand();

                        brand.brandID = rd["brandID"].ToString();
                        brand.brandName = rd["brandName"].ToString();
                        brand.brandCategory = rd["brandCategory"].ToString();
                        brand.brandStatus = rd["brandStatus"].ToString();

                        brand.created_at = rd["created_at"].ToString();
                        brand.updated_at = rd["updated_at"].ToString();

                        listOfBrand.Add(brand);

                    }

                    return listOfBrand;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF READ ALL BRAND ACTIVE

        public List<VehicleBrand> searchBrands_all(string searchText)
        {

            searchText = Sanitize(searchText);

            try
            {
                openConnection();
                sql = @"SELECT * FROM tblvehiclebrand WHERE brandName LIKE '%" + searchText +
                                                    "%' OR brandStatus LIKE '%" + searchText +
                                                    "%'";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfBrand = new List<VehicleBrand>();

                    while (rd.Read())
                    {

                        var brand = new VehicleBrand();

                        brand.brandID = rd["brandID"].ToString();
                        brand.brandName = rd["brandName"].ToString();
                        brand.brandCategory = rd["brandCategory"].ToString();
                        brand.brandStatus = rd["brandStatus"].ToString();

                        brand.created_at = rd["created_at"].ToString();
                        brand.updated_at = rd["updated_at"].ToString();

                        listOfBrand.Add(brand);

                    }

                    return listOfBrand;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF SEARCH FROM ALL BRAND

        public Boolean createVehicleInfo(VehicleInfo passedData)
        {
            bool reqStatus = false;

            passedData.vehicleOwner = Sanitize(passedData.vehicleOwner);
            passedData.vehiclePlateNo = Sanitize(passedData.vehiclePlateNo);
            passedData.vehicleBrand = Sanitize(passedData.vehicleBrand);
            passedData.vehicleColor = Sanitize(passedData.vehicleColor);

            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
            passedData.created_at = date;


            try
            {
                openConnection();
                sql = @"INSERT INTO tblvehicleinfo SET vehicleOwner='" + passedData.vehicleOwner +
                                       "', vehiclePlateNo='" + passedData.vehiclePlateNo +
                                       "', vehicleBrand='" + passedData.vehicleBrand +
                                       "', vehicleColor='" + passedData.vehicleColor +
                                       "', created_at='" + passedData.created_at + "'";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                reqStatus = true;
            }
            catch
            {
                reqStatus = false;
            }
            finally
            {
                con.Close();
            }

            return reqStatus;
        }//END OF CREATE VEHICLE INFO

        public Boolean createReceiptReference(ReceiptReference passedData)
        {
            bool reqStatus = false;
            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");

            /*
             *  refBarcode
             *  refVehicleID
             * 	refParkingID
             * 	refTimeIn
             * 	refPersonnelIn
             * 	refStatus
             * 	created_at
             */

            passedData.refBarcode = passedData.refBarcode;
            passedData.refVehicleID = passedData.refVehicleID;
            passedData.refParkingID = passedData.refParkingID;
            passedData.refPersonnelIn = passedData.refPersonnelIn;
            passedData.refTimeIn = date;
            passedData.refStatus = "PENDING";
            passedData.created_at = date;

            try
            {
                openConnection();
                sql = @"INSERT INTO tblreceiptreference SET refBarcode='" + passedData.refBarcode +
                                       "', refVehicleID='" + passedData.refVehicleID +
                                       "', refParkingID='" + passedData.refParkingID +
                                       "', refPersonnelIn='" + passedData.refPersonnelIn +
                                       "', refTimeIn='" + passedData.refTimeIn +
                                       "', refStatus='" + passedData.refStatus +
                                       "', created_at='" + passedData.created_at + "'";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                reqStatus = true;
            }
            catch
            {
                reqStatus = false;
            }
            finally
            {
                con.Close();
            }

            return reqStatus;
        }//END OF CREATE TRANSACTION

        public Boolean updateReceiptReference(ReceiptReference passedData)
        {
            bool reqStatus = false;

            passedData.refID = passedData.refID;
            passedData.refStatus = passedData.refStatus;
            passedData.refPersonnelOut = passedData.refPersonnelOut;
            passedData.refTimeCount = passedData.refTimeCount;
            passedData.refPrice = passedData.refPrice;
            passedData.refAmountPaid = passedData.refAmountPaid;
            passedData.refAmountChange = passedData.refAmountChange;

            DateTime enteredDate = DateTime.Parse(passedData.refTimeOut);
            passedData.refTimeOut = enteredDate.ToString("yyyy-MM-dd H:mm:ss");

            try
            {
                openConnection();
                sql = @"UPDATE tblreceiptreference SET refStatus='" + passedData.refStatus +
                                       "', refPersonnelOut='" + passedData.refPersonnelOut +
                                       "', refTimeCount='" + passedData.refTimeCount +
                                       "', refPrice='" + passedData.refPrice +
                                       "', refAmountPaid='" + passedData.refAmountPaid +
                                       "', refAmountChange='" + passedData.refAmountChange +
                                       "', refTimeOut='" + passedData.refTimeOut +
                                       "' WHERE refID='" + passedData.refID + "'";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                reqStatus = true;
            }
            catch
            {
                reqStatus = false;
            }
            finally
            {
                con.Close();
            }

            return reqStatus;
        }//END OF UPDATE TRANSACTION

        public List<ReceiptReference> readReceiptRefence_pending()
        {

            try
            {
                openConnection();
                sql = "SELECT * FROM tblreceiptreference WHERE refStatus='PENDING'";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfReceipt = new List<ReceiptReference>();

                    while (rd.Read())
                    {

                        var receipt = new ReceiptReference();

                        receipt.refID = rd["refID"].ToString();
                        receipt.refBarcode = rd["refBarcode"].ToString();
                        receipt.refParkingID = rd["refParkingID"].ToString();
                        receipt.refTimeIn = rd["refTimeIn"].ToString();
                        receipt.refStatus = rd["refStatus"].ToString();

                        listOfReceipt.Add(receipt);

                    }

                    return listOfReceipt;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF READ ALL PENDING ACCOUNT

        public List<ReceiptReference> searchReceiptRefence_pending(string searchText)
        {

            searchText = Sanitize(searchText);

            try
            {
                openConnection();
                sql = @"SELECT * FROM tblreceiptreference WHERE (refBarcode LIKE '%" + searchText +
                                                    "%' OR 	refParkingID LIKE '%" + searchText +
                                                    "%') AND refStatus='PENDING'";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfReceipt = new List<ReceiptReference>();

                    while (rd.Read())
                    {

                        var receipt = new ReceiptReference();

                        receipt.refID = rd["refID"].ToString();
                        receipt.refBarcode = rd["refBarcode"].ToString();
                        receipt.refParkingID = rd["refParkingID"].ToString();
                        receipt.refTimeIn = rd["refTimeIn"].ToString();
                        receipt.refStatus = rd["refStatus"].ToString();

                        listOfReceipt.Add(receipt);

                    }

                    return listOfReceipt;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF SEARCH FROM ALL PENDING ACCOUNT

        public List<JoinAccountInfo> searchReceiptRefence_pending_specific(string searchText)
        {

            try
            {
                openConnection();
                sql = @"SELECT * FROM (((tblreceiptreference A INNER JOIN tblvehicleinfo B ON A.refVehicleID = B.vehicleID) 
                                    INNER JOIN tblparkingslot C ON A.refParkingID = C.slotID) 
                                    INNER JOIN tblvehiclebrand D ON D.brandID = B.vehicleBrand)
                                    INNER JOIN tblvehicletype E ON E.typeID = D.brandCategory WHERE A.refBarcode='" + searchText + "' AND refStatus='PENDING'";


                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfReceipt = new List<JoinAccountInfo>();

                    while (rd.Read())
                    {

                        var receipt = new JoinAccountInfo();

                        receipt.refID = rd["refID"].ToString();
                        receipt.refBarcode = rd["refBarcode"].ToString();
                        receipt.refVehicleID = rd["refVehicleID"].ToString();
                        receipt.refParkingID = rd["refParkingID"].ToString();
                        receipt.refTimeIn = rd["refTimeIn"].ToString();
                        //receipt.refTimeOut = rd["refTimeOut"].ToString();
                        receipt.refPersonnelIn = rd["refPersonnelIn"].ToString();
                        receipt.refPersonnelOut = rd["refPersonnelOut"].ToString();
                        receipt.refStatus = rd["refStatus"].ToString();
                        receipt.refTimeCount = rd["refTimeCount"].ToString();
                        receipt.refPrice = rd["refPrice"].ToString();
                        receipt.refAmountChange = rd["refAmountChange"].ToString();
                        receipt.refAmountPaid = rd["refAmountPaid"].ToString();

                        receipt.vehicleOwner = rd["vehicleOwner"].ToString();
                        receipt.slotBlock = rd["slotBlock"].ToString();
                        receipt.slotNumber = rd["slotNumber"].ToString();
                        receipt.typeRatePerHour = rd["typeRatePerHour"].ToString();
                        receipt.vehicleColor = rd["vehicleColor"].ToString();
                        receipt.vehiclePlateNo = rd["vehiclePlateNo"].ToString();
                        receipt.typeName = rd["typeName"].ToString();
                        receipt.brandName = rd["brandName"].ToString();

                        listOfReceipt.Add(receipt);

                    }

                    return listOfReceipt;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF SEARCH SPECIFIC PENDING ACCOUNT

        public List<JoinAccountInfo> searchReceiptRefence_transactions(string dtFrom, string dtTo)
        {

            DateTime dfrom = DateTime.Parse(dtFrom);
            dtFrom = dfrom.ToString("yyyy-MM-dd");

            DateTime dto = DateTime.Parse(dtTo);
            dtTo = dto.ToString("yyyy-MM-dd");

            try
            {
                openConnection();
                sql = @"SELECT * FROM (((tblreceiptreference A INNER JOIN tblvehicleinfo B ON A.refVehicleID = B.vehicleID) 
                                    INNER JOIN tblparkingslot C ON A.refParkingID = C.slotID) 
                                    INNER JOIN tblvehiclebrand D ON D.brandID = B.vehicleBrand)
                                    INNER JOIN tblvehicletype E ON E.typeID = D.brandCategory WHERE A.refStatus='PAID' AND (A.created_at BETWEEN '" + dtFrom + "' AND '" + dtTo + "') ORDER BY A.refID";


                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfReceipt = new List<JoinAccountInfo>();

                    while (rd.Read())
                    {

                        var receipt = new JoinAccountInfo();

                        receipt.refID = rd["refID"].ToString();
                        receipt.refBarcode = rd["refBarcode"].ToString();
                        receipt.refVehicleID = rd["refVehicleID"].ToString();
                        receipt.refParkingID = rd["refParkingID"].ToString();
                        receipt.refTimeIn = rd["refTimeIn"].ToString();
                        receipt.refTimeOut = rd["refTimeOut"].ToString();
                        receipt.refPersonnelIn = rd["refPersonnelIn"].ToString();
                        receipt.refPersonnelOut = rd["refPersonnelOut"].ToString();
                        receipt.refStatus = rd["refStatus"].ToString();
                        receipt.refTimeCount = rd["refTimeCount"].ToString();
                        receipt.refPrice = rd["refPrice"].ToString();
                        receipt.refAmountChange = rd["refAmountChange"].ToString();
                        receipt.refAmountPaid = rd["refAmountPaid"].ToString();

                        receipt.vehicleOwner = rd["vehicleOwner"].ToString();
                        receipt.slotBlock = rd["slotBlock"].ToString();
                        receipt.slotNumber = rd["slotNumber"].ToString();
                        receipt.typeRatePerHour = rd["typeRatePerHour"].ToString();
                        receipt.vehicleColor = rd["vehicleColor"].ToString();
                        receipt.vehiclePlateNo = rd["vehiclePlateNo"].ToString();
                        receipt.typeName = rd["typeName"].ToString();
                        receipt.brandName = rd["brandName"].ToString();

                        listOfReceipt.Add(receipt);

                    }

                    return listOfReceipt;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF SEARCH TRANSACTIONS PER DATE

        public String lastInsertedVehicleInfo()
        {
            string lastInsertedID = null;

            try
            {
                openConnection();
                sql = "SELECT vehicleID FROM tblvehicleinfo ORDER BY vehicleID DESC LIMIT 0,1";

                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lastInsertedID = rd["vehicleID"].ToString();
                    }
                }
            }
            catch
            {
                lastInsertedID = null;
            }
            finally
            {
                con.Close();
            }


            return lastInsertedID;
        }

        public Boolean updateParkingSpace(ParkingSlot passedData)
        {
            bool reqStatus = false;
            passedData.slotIsAvailable = passedData.slotIsAvailable;
            passedData.slotID = passedData.slotID;
            
            try
            {
                openConnection();
                sql = @"UPDATE tblparkingslot SET slotIsAvailable='" + passedData.slotIsAvailable +
                                       "' WHERE slotID='" + passedData.slotID + "'";

                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                reqStatus = true;
            }
            catch
            {
                reqStatus = false;
            }
            finally
            {
                con.Close();
            }

            return reqStatus;
        }//END OF UPDATE PARKING SLOT

        public List<ParkingSlot> readParkingSlot_all()
        {

            try
            {
                openConnection();
                sql = "SELECT * FROM tblparkingslot";
                cmd = new MySqlCommand(sql, con);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    var listOfParkingSlots = new List<ParkingSlot>();

                    while (rd.Read())
                    {

                        var slot = new ParkingSlot();
                        slot.slotID = rd["slotID"].ToString();
                        slot.slotNumber = rd["slotNumber"].ToString();
                        slot.slotIsAvailable = rd["slotIsAvailable"].ToString();
                        listOfParkingSlots.Add(slot);

                    }

                    return listOfParkingSlots;
                }
                else
                {
                    Console.WriteLine("No data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return null;

        }//END OF READ ALL PARKING SLOT
    }
}
