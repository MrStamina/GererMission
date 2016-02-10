using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using GérerMission.Exceptions;


namespace GérerMission.Dao
{
    using GérerMission.Metier;
    class DaoMission
    {
        // Création de la connexion vers la base Sql
        private static SqlConnection GetConnection()
        {
            string strConn = "Data Source=(local);" +
                                             "Initial Catalog = ChasseurDeTete;" +
                                             "Integrated Security = True;" +
                                             "Connection TimeOut = 10";

            SqlConnection sqlConnect = new SqlConnection(strConn);


            try
            {
                sqlConnect.Open();
                return sqlConnect;
            }
            catch (SqlException se)
            {
                throw new DaoExceptionFinApplication("Connexion impossible à la base de données, l'application va se fermer, veuillez recommencer ultèrieurement : \n" + se.Message, se);
            }
        }

        // Récupération de la liste des entreprises

        public static List<Entreprise> GetAllEntreprises()
        {
            List<Entreprise> Entreprises = new List<Entreprise>();
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "GetAllEntreprises";

                    try
                    {
                        sqlCde.CommandType = CommandType.StoredProcedure;
                        sqlCde.CommandText = strsql;
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            Entreprise entreprise = new Entreprise()
                            {
                                IdEntreprise = sqlRdr.GetInt32(0),
                                RaisonSociale = sqlRdr.GetString(3)
                            };
                            Entreprises.Add(entreprise);
                        }
                        sqlRdr.Close();
                        return Entreprises;
                    }
                    catch (SqlException ex)
                    {
                        throw new DaoExceptionFinApplication("Chargement des entreprises impossible, l'application va se fermer: \n" + ex.Message, ex);
                    }
                }
            }
        }

        // Récupération de la liste des qualifications
        public static List<Qualification> GetAllQualifications()
        {

            List<Qualification> Qualif = new List<Qualification>();

            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "GetAllQualifications";

                    try
                    {
                        sqlCde.CommandType = CommandType.StoredProcedure;
                        sqlCde.CommandText = strsql;
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            Qualification qualification = new Qualification()
                            {
                                IdQualification = sqlRdr.GetInt32(0),
                                LibelleQualification = sqlRdr.GetString(1)
                            };
                            Qualif.Add(qualification);

                        }
                        sqlRdr.Close();
                        return Qualif;

                    }
                    catch (SqlException ex)
                    {
                        throw new DaoExceptionFinApplication("Chargement des qualifications impossible, l'application va se fermer: \n" + ex.Message, ex);
                    }
                }
            }
        }

        // Récupération de la liste des consultants

        public static List<Consultant> GetAllConsultants()
        {
            List<Consultant> Consultants = new List<Consultant>();
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "GetAllConsultants";

                    try
                    {
                        sqlCde.CommandType = CommandType.StoredProcedure;
                        sqlCde.CommandText = strsql;
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            Consultant consult = new Consultant()
                            {
                                IdConsultant = (sbyte)sqlRdr.GetByte(0),
                                NomConsultant = sqlRdr.GetString(1),
                                PrenomConsultant = sqlRdr.GetString(2)
                            };
                            Consultants.Add(consult);
                        }
                        sqlRdr.Close();
                        return Consultants;
                    }
                    catch (SqlException ex)
                    {
                        throw new DaoExceptionFinApplication("Chargement des consultants impossible, l'application va se fermer: \n" + ex.Message, ex);
                    }
                }
            }
        }

        // Récupération de la liste des missions

        public static List<Mission> GetAllMissions(int idEntre)
        {
            List<Mission> Missions = new List<Mission>();
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "GetAllMissions";
                    sqlCde.CommandType = CommandType.StoredProcedure;
                    sqlCde.CommandText = strsql;
                    SqlParameter p1 = new SqlParameter("@vidEntreprise", SqlDbType.Int);
                    p1.Direction = ParameterDirection.Input;
                    p1.Value = idEntre;
                    sqlCde.Parameters.Add(p1);
                    
                    try
                    {
                        
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            int idMission = sqlRdr.GetInt32(0);
                            Entreprise ent = new Entreprise() { IdEntreprise = sqlRdr.GetInt32(1) };
                            MotifFin motif = (!sqlRdr.IsDBNull(2)) ? new MotifFin() { IdMotif = (sbyte)sqlRdr.GetByte(2) } : null;
                            Qualification qualif = new Qualification() { IdQualification = sqlRdr.GetInt32(3), LibelleQualification = sqlRdr.GetString(4) };
                            Niveau niv = (!sqlRdr.IsDBNull(5)) ? new Niveau() { IdNiveau = (sbyte)sqlRdr.GetByte(5) } : null;
                            Consultant consult = new Consultant() { IdConsultant = (sbyte)sqlRdr.GetByte(6) };
                            DateTime dateOuv = sqlRdr.GetDateTime(7);
                            DateTime? dateFin = (sqlRdr.IsDBNull(8)) ? (DateTime?)null : sqlRdr.GetDateTime(8);
                            decimal? remu = (sqlRdr.IsDBNull(9)) ? (decimal?)null : sqlRdr.GetDecimal(9);
                            string precis = (!sqlRdr.IsDBNull(10)) ? sqlRdr.GetString(10) : string.Empty;
                            sbyte? duree = (sqlRdr.IsDBNull(11)) ? (sbyte?)null : (sbyte)sqlRdr.GetByte(11);

                            Mission miss = new Mission(idMission, ent, motif, qualif, niv, consult, dateOuv, dateFin, remu, precis, duree);
                            Missions.Add(miss);
                           
                               
                        }  
                        sqlRdr.Close();
                        return Missions;
                    }
                    catch (SqlException ex)
                    {
                        throw new DaoExceptionFinApplication("Chargement des missions impossible, l'application va se fermer: \n" + ex.Message, ex);
                    }
                }
            }
        }

        // récupération des motifs et des niveaux

        public static List<Niveau> GetAllNiveau()
        {
            List<Niveau> oNiveau = new List<Niveau>();

            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "GetAllNiveau";

                    try
                    {
                        sqlCde.CommandType = CommandType.StoredProcedure;
                        sqlCde.CommandText = strsql;
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            Niveau niv = new Niveau()
                            {
                                IdNiveau = (sbyte)sqlRdr.GetByte(0),
                                Libelle = sqlRdr.GetString(1)
                            };
                            oNiveau.Add(niv);

                        }
                        sqlRdr.Close();
                        return oNiveau;

                    }
                    catch (SqlException ex)
                    {
                        throw new DaoExceptionFinApplication("Chargement des qualifications impossible, l'application va se fermer: \n" + ex.Message, ex);
                    }
                }
            }
        }
        public static List<MotifFin> GetAllMotif()
        {
            List<MotifFin> oMotif = new List<MotifFin>();

            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "GetAllMotif";

                    try
                    {
                        sqlCde.CommandType = CommandType.StoredProcedure;
                        sqlCde.CommandText = strsql;
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            MotifFin mot = new MotifFin()
                            {
                                IdMotif = (sbyte)sqlRdr.GetByte(0),
                                LibelleMotif = sqlRdr.GetString(1)
                            };
                            oMotif.Add(mot);

                        }
                        sqlRdr.Close();
                        return oMotif;

                    }
                    catch (SqlException ex)
                    {
                        throw new DaoExceptionFinApplication("Chargement des qualifications impossible, l'application va se fermer: \n" + ex.Message, ex);
                    }
                }
            }
        }



        //Gestion de la modification d'une mission

        #region Modif/Ajout/Suppression de mission
        public static bool UpdMission(Mission miss)
        {
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "UpdMissions";
                    sqlCde.CommandText = strsql;
                    sqlCde.CommandType = CommandType.StoredProcedure;
                    sqlCde.Parameters.Clear();
                    sqlCde.Parameters.Add(new SqlParameter("@idm", SqlDbType.Int)).Value = miss.IdMission;
                    sqlCde.Parameters.Add(new SqlParameter("@vidEntreprise", SqlDbType.Int)).Value = miss.EntrepriseOffre.IdEntreprise;
                    sqlCde.Parameters.Add(new SqlParameter("@vidMotif", SqlDbType.TinyInt)).Value = null;
                    sqlCde.Parameters.Add(new SqlParameter("@vidQualif", SqlDbType.Int)).Value = miss.QualificationDemandee.IdQualification;
                    sqlCde.Parameters.Add(new SqlParameter("@vidNiveau",SqlDbType.TinyInt)).Value = miss.NiveauDemande.IdNiveau;
                    sqlCde.Parameters.Add(new SqlParameter("@vidConsult",SqlDbType.TinyInt)).Value = miss.Consult.IdConsultant;
                    sqlCde.Parameters.Add(new SqlParameter("@vDateouv", SqlDbType.DateTime)).Value = miss.DateOuverture;
                    sqlCde.Parameters.Add(new SqlParameter("@vDatefin", SqlDbType.DateTime)).Value = miss.DateFin;
                    sqlCde.Parameters.Add(new SqlParameter("@vRemu", SqlDbType.Money)).Value = miss.RemunerationProposee;
                    sqlCde.Parameters.Add(new SqlParameter("@vPreci", SqlDbType.VarChar)).Value = miss.Precisions;
                    sqlCde.Parameters.Add(new SqlParameter("@vDuree", SqlDbType.TinyInt)).Value = miss.Duree;
                    try
                    {
                        int n = sqlCde.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("La suppression a échoué");
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        throw new DaoExceptionAfficheMessage("La suppression a échoué : \n" + ex.Message, ex);
                    }
                }
            }
        }

        // Ajout d'une mission

        public static bool AddMission(Mission miss, out int idMission)
        {
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strSql = "AddMission";
                    try
                    {
                        sqlCde.CommandType = CommandType.StoredProcedure;
                        sqlCde.CommandText = strSql;

                        //Paramètres
                        sqlCde.Parameters.Add(new SqlParameter("@idEntreprise", SqlDbType.Int)).Value = miss.CodeEntreprise;
                        if (miss.Motif != null)
                            sqlCde.Parameters.Add(new SqlParameter("@idMotif", SqlDbType.TinyInt)).Value = miss.Motif.IdMotif;
                        sqlCde.Parameters.Add(new SqlParameter("@idQualification", SqlDbType.Int)).Value = miss.QualificationDemandee.IdQualification;
                        if(miss.NiveauDemande != null)
                        sqlCde.Parameters.Add(new SqlParameter("@idNiveau", SqlDbType.TinyInt)).Value = miss.NiveauDemande.IdNiveau;
                        sqlCde.Parameters.Add(new SqlParameter("@idConsultant", SqlDbType.TinyInt)).Value = miss.Consult.IdConsultant;
                        sqlCde.Parameters.Add(new SqlParameter("@dateouverture", SqlDbType.DateTime)).Value = miss.DateOuverture;
                        if (miss.DateFin != null)
                            sqlCde.Parameters.Add(new SqlParameter("@datefin", SqlDbType.DateTime)).Value = miss.DateFin;
                        if (miss.RemunerationProposee != null)
                            sqlCde.Parameters.Add(new SqlParameter("@remu", SqlDbType.Money)).Value = miss.RemunerationProposee;
                        if(miss.Precisions != string.Empty)
                        sqlCde.Parameters.Add(new SqlParameter("@precision", SqlDbType.VarChar)).Value = miss.Precisions;
                        if (miss.Duree != null)
                            sqlCde.Parameters.Add(new SqlParameter("@duree", SqlDbType.TinyInt)).Value = miss.Duree;

                        //Paramètre de sortie
                        sqlCde.Parameters.Add(new SqlParameter("@idMission", SqlDbType.Int)).Direction = ParameterDirection.Output;

                        int n = sqlCde.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("La création de la mission a échoué");
                        else
                            idMission = (int)sqlCde.Parameters["@idMission"].Value;
                        return true;
                    }
                    catch(SqlException ex)
                    {
                        throw new DaoExceptionAfficheMessage("La création de la mission a échoué : \n" + ex.Message, ex);
                    }

                }
            }
        }

        //Gestion de la suppression d'une mission
        public static bool DelMission(Mission miss)
        {
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    sqlCde.Connection = sqlConnect;
                    string strsql = "DelMission";
                    sqlCde.CommandText = strsql;
                    sqlCde.CommandType = CommandType.StoredProcedure;
                    sqlCde.Parameters.Clear();
                    sqlCde.Parameters.Add(new SqlParameter("@idMission", SqlDbType.Int)).Value = miss.IdMission;
                    try
                    {
                        int n = sqlCde.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("La suppression a échoué");
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        throw new DaoExceptionAfficheMessage("La suppression a échoué : \n" + ex.Message, ex);
                    }
                }
            }
        }
        #endregion
    }

}
