//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option or rebuild the Visual Studio project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SetupResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SetupResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.SetupResource", global::System.Reflection.Assembly.Load("App_GlobalResources"));
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to mojoSetup has detected that the database user does not have permission to alter the database schema. You need to correct this or provide a connection string with sufficient permission..
        /// </summary>
        internal static string CantAlterSchemaWarning {
            get {
                return ResourceManager.GetString("CantAlterSchemaWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to mojoSetup has detected that the database user does not have permission to create temporary tables. You need to correct this or some important features will not work..
        /// </summary>
        internal static string CantCreateTempTablesMessage {
            get {
                return ResourceManager.GetString("CantCreateTempTablesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setup cannot proceed until the issues shown above have been corrected..
        /// </summary>
        internal static string CantProceedMessage {
            get {
                return ResourceManager.GetString("CantProceedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You need to upgrade the Web Site and Database Code to the same version as the Database Schema..
        /// </summary>
        internal static string CodeUpgradeNeededMessage {
            get {
                return ResourceManager.GetString("CodeUpgradeNeededMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuring feature {0}.
        /// </summary>
        internal static string ConfigureFeatureMessage {
            get {
                return ResourceManager.GetString("ConfigureFeatureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuring {0}....
        /// </summary>
        internal static string ConfigureFeaturesMessage {
            get {
                return ResourceManager.GetString("ConfigureFeaturesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Connection String you entered is not correct or does not have sufficient permission to alter the database.
        /// </summary>
        internal static string ConnectionStringFailedMessage {
            get {
                return ResourceManager.GetString("ConnectionStringFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection String is Required.
        /// </summary>
        internal static string ConnectionStringRequiredError {
            get {
                return ResourceManager.GetString("ConnectionStringRequiredError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not install application {0} because the folder {1} does not exist..
        /// </summary>
        internal static string CouldNotInstallFeatureSchemaMessage {
            get {
                return ResourceManager.GetString("CouldNotInstallFeatureSchemaMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create Initial Data.
        /// </summary>
        internal static string CreateInitialDataButton {
            get {
                return ResourceManager.GetString("CreateInitialDataButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No pages found so creating default content....
        /// </summary>
        internal static string CreatingDefaultContent {
            get {
                return ResourceManager.GetString("CreatingDefaultContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating page {0}.
        /// </summary>
        internal static string CreatingPageMessage {
            get {
                return ResourceManager.GetString("CreatingPageMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating roles and admin user....
        /// </summary>
        internal static string CreatingRolesAndAdminUserMessage {
            get {
                return ResourceManager.GetString("CreatingRolesAndAdminUserMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating site with default settings....
        /// </summary>
        internal static string CreatingSiteMessage {
            get {
                return ResourceManager.GetString("CreatingSiteMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to database permissions are sufficient to alter schema..
        /// </summary>
        internal static string DatabaseCanAlterSchemaMessage {
            get {
                return ResourceManager.GetString("DatabaseCanAlterSchemaMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to database permissions are sufficient to create temporary tables..
        /// </summary>
        internal static string DatabaseCanCreateTempTablesMessage {
            get {
                return ResourceManager.GetString("DatabaseCanCreateTempTablesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database Code Version.
        /// </summary>
        internal static string DatabaseCodeVersionLabel {
            get {
                return ResourceManager.GetString("DatabaseCodeVersionLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to database connection ok..
        /// </summary>
        internal static string DatabaseConnectionOKMessage {
            get {
                return ResourceManager.GetString("DatabaseConnectionOKMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database Creation Succeeded.
        /// </summary>
        internal static string DatabaseCreationSucceeded {
            get {
                return ResourceManager.GetString("DatabaseCreationSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database Platform.
        /// </summary>
        internal static string DatabasePlatformLabel {
            get {
                return ResourceManager.GetString("DatabasePlatformLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to database initial schema already exists..
        /// </summary>
        internal static string DatabaseSchemaAlreadyExistsMessage {
            get {
                return ResourceManager.GetString("DatabaseSchemaAlreadyExistsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to database core schema needs upgrade..
        /// </summary>
        internal static string DatabaseSchemaNeedsUpgradeMessage {
            get {
                return ResourceManager.GetString("DatabaseSchemaNeedsUpgradeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to database initial schema needs to be created..
        /// </summary>
        internal static string DatabaseSchemaNotCreatedYetMessage {
            get {
                return ResourceManager.GetString("DatabaseSchemaNotCreatedYetMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to database core schema is up to date..
        /// </summary>
        internal static string DatabaseSchemaUpToDateMessage {
            get {
                return ResourceManager.GetString("DatabaseSchemaUpToDateMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status.
        /// </summary>
        internal static string DatabaseStatusLabel {
            get {
                return ResourceManager.GetString("DatabaseStatusLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  The Data folder beneath the root of the web site is not writable by the ASP.NET worker process. 
        ///
        ///You need to make this folder and all its child folders and files writable before setup can proceed. mojoPortal needs this to be able to write search index files, error logs, image gallery uploads, and other important features. 
        ///
        ///Right Click the Data folder in Windows explorer, choose properties and go to the Security tab. (On XP if you don&apos;t see the security tab then google for XP Simple File sharing to lea [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DataFolderNotWritableMessage {
            get {
                return ResourceManager.GetString("DataFolderNotWritableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Data/Sites/1/GalleryImages folder is not writable.
        /// </summary>
        internal static string DataGalleryFolderNotWritableMessage {
            get {
                return ResourceManager.GetString("DataGalleryFolderNotWritableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Data folder is not writable..
        /// </summary>
        internal static string DataRootNotWritableMessage {
            get {
                return ResourceManager.GetString("DataRootNotWritableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Data/Sites/1/SharedFiles/ folder is not writable.
        /// </summary>
        internal static string DataSharedFilesFolderNotWritableMessage {
            get {
                return ResourceManager.GetString("DataSharedFilesFolderNotWritableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Data/Sites/1/SharedFiles/History/ folder is not writable.
        /// </summary>
        internal static string DataSharedFilesHistoryFolderNotWritableMessage {
            get {
                return ResourceManager.GetString("DataSharedFilesHistoryFolderNotWritableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Data/Sites/1/ folder is not writable.
        /// </summary>
        internal static string DataSiteFolderNotWritableMessage {
            get {
                return ResourceManager.GetString("DataSiteFolderNotWritableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Data/Sites/1/index/ folder is not writable.
        /// </summary>
        internal static string DataSiteIndexFolderNotWritableMessage {
            get {
                return ResourceManager.GetString("DataSiteIndexFolderNotWritableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Data/Sites/1/systemfiles/ folder is not writable.
        /// </summary>
        internal static string DataSystemFilesFolderNotWritableMessage {
            get {
                return ResourceManager.GetString("DataSystemFilesFolderNotWritableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ensuring all features are installed in server admin sites....
        /// </summary>
        internal static string EnsuringFeaturesInAdminSites {
            get {
                return ResourceManager.GetString("EnsuringFeaturesInAdminSites", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error Message.
        /// </summary>
        internal static string ErrorMessageLabel {
            get {
                return ResourceManager.GetString("ErrorMessageLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error Occurred.
        /// </summary>
        internal static string ErrorOccurredLabel {
            get {
                return ResourceManager.GetString("ErrorOccurredLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} site(s) found..
        /// </summary>
        internal static string ExistingSiteCountMessageMessage {
            get {
                return ResourceManager.GetString("ExistingSiteCountMessageMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The system cannot connect to the {0} database. Please check your connection string..
        /// </summary>
        internal static string FailedToConnectToDatabase {
            get {
                return ResourceManager.GetString("FailedToConnectToDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To see the specific connection error message, set ShowConnectionErrorOnSetup to true in Web.config.
        /// </summary>
        internal static string FailedToConnectToDatabaseHelp {
            get {
                return ResourceManager.GetString("FailedToConnectToDatabaseHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File system permissions problems found..
        /// </summary>
        internal static string FileSystemPermissionProblemsMessage {
            get {
                return ResourceManager.GetString("FileSystemPermissionProblemsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File system permissions ok..
        /// </summary>
        internal static string FileSystemPermissionsOKMesage {
            get {
                return ResourceManager.GetString("FileSystemPermissionsOKMesage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automatic schema creation is not yet working for Firebird Sql. You will need to maually run the script located at.
        /// </summary>
        internal static string FirebirdAutoDBCreationNotYetSupportedException {
            get {
                return ResourceManager.GetString("FirebirdAutoDBCreationNotYetSupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automatic shema upgrading is not yet supported for Firebird. You will need to run the scripts located at {0) starting after {1}.config.
        /// </summary>
        internal static string FirebirdAutoUpgradeNotYetSupportedException {
            get {
                return ResourceManager.GetString("FirebirdAutoUpgradeNotYetSupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder Details.
        /// </summary>
        internal static string FolderDetailsLabel {
            get {
                return ResourceManager.GetString("FolderDetailsLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Site Home Page.
        /// </summary>
        internal static string HomeLink {
            get {
                return ResourceManager.GetString("HomeLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your installation is up to date..
        /// </summary>
        internal static string InstallationUpToDateMessage {
            get {
                return ResourceManager.GetString("InstallationUpToDateMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The last server error was:.
        /// </summary>
        internal static string LastServerErrorLabel {
            get {
                return ResourceManager.GetString("LastServerErrorLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To comment out NeatUpload, look in Web.config file in the &lt;httpModules&gt; section and change this:.
        /// </summary>
        internal static string MediumTrustCommentOutNeatUploadInstructionLine1 {
            get {
                return ResourceManager.GetString("MediumTrustCommentOutNeatUploadInstructionLine1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You should comment out the NeatUpload module as it is not supported in Medium Trust, unless its installed in the Global Assembly Cache on the server.
        ///For more information see http://www.mojoportal.com/mediumtrust.aspx.
        /// </summary>
        internal static string MediumTrustCommentOutNeatUploadPreambleMessage {
            get {
                return ResourceManager.GetString("MediumTrustCommentOutNeatUploadPreambleMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This site appears to be running in a secured environment using Medium Trust policy or at least lower than Full Trust. mojoPortal is not supported in less than Full Trust hosting..
        /// </summary>
        internal static string MediumTrustGeneralMessage {
            get {
                return ResourceManager.GetString("MediumTrustGeneralMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order for the Search Engine to work in Medium trust, you need to add this in Web.config in the AppSettings section:.
        /// </summary>
        internal static string MediumTrustLuceneConfigPreambleMessage {
            get {
                return ResourceManager.GetString("MediumTrustLuceneConfigPreambleMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to use MySQL under Medium Trust, The MySQL Connector for .NET must be installed in the Global Assembly Cache on the server. If you see a SecurityException in the error message then the Connector is not installed.
        ///You can download the MySql Connector for .NET from here: http://dev.mysql.com/downloads/connector/net/5.0.html.
        /// </summary>
        internal static string MediumTrustMySQLMessage {
            get {
                return ResourceManager.GetString("MediumTrustMySQLMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!--
        ///&lt;add name=&quot;HttpUploadModule&quot; type=&quot;Brettle.Web.NeatUpload.UploadHttpModule, Brettle.Web.NeatUpload&quot; /&gt;
        ///--&gt;.
        /// </summary>
        internal static string MediumTrustNeatUploadCommentedOutExample {
            get {
                return ResourceManager.GetString("MediumTrustNeatUploadCommentedOutExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;add name=&quot;HttpUploadModule&quot; type=&quot;Brettle.Web.NeatUpload.UploadHttpModule, Brettle.Web.NeatUpload&quot; /&gt;.
        /// </summary>
        internal static string MediumTrustNeatUploadWrongConfigExample {
            get {
                return ResourceManager.GetString("MediumTrustNeatUploadWrongConfigExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to use PostgreSQL under Medium Trust, the npgsql Data Access library must be installedin the Global Assembly Cache on the server. If you see a SecurityException below then the npgsql component is not installed.
        ///You can get more information or download npgsql from here: http://npgsql.projects.postgresql.org/.
        /// </summary>
        internal static string MediumTrustnpgsqlMessage {
            get {
                return ResourceManager.GetString("MediumTrustnpgsqlMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No scripts found in folder.
        /// </summary>
        internal static string NoScriptsFilesFoundMessage {
            get {
                return ResourceManager.GetString("NoScriptsFilesFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Sites have been created yet, click the button to create initial site data..
        /// </summary>
        internal static string NoSitesMessage {
            get {
                return ResourceManager.GetString("NoSitesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No upgrade scripts found for {0}. Probably up to date..
        /// </summary>
        internal static string NoUpgradeScriptsFound {
            get {
                return ResourceManager.GetString("NoUpgradeScriptsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection String:.
        /// </summary>
        internal static string OverrideConnectionStringLabel {
            get {
                return ResourceManager.GetString("OverrideConnectionStringLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Probing system....
        /// </summary>
        internal static string ProbingSystemMessage {
            get {
                return ResourceManager.GetString("ProbingSystemMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running script {0} - {1}.
        /// </summary>
        internal static string RunningScriptMessage {
            get {
                return ResourceManager.GetString("RunningScriptMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setup is disabled but running setup anyway because current user is an administrator..
        /// </summary>
        internal static string RunningSetupForAdminUser {
            get {
                return ResourceManager.GetString("RunningSetupForAdminUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTC Run Time.
        /// </summary>
        internal static string RunTimeLabel {
            get {
                return ResourceManager.GetString("RunTimeLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Did not try to upgrade the application {0} because the folder {1} does not exist..
        /// </summary>
        internal static string SchemaUpgradeFolderNotFound {
            get {
                return ResourceManager.GetString("SchemaUpgradeFolderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You need to upgrade the Database Schema to make it the same version as the code..
        /// </summary>
        internal static string SchemaUpgradeNeededMessage {
            get {
                return ResourceManager.GetString("SchemaUpgradeNeededMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script File.
        /// </summary>
        internal static string ScriptFileLabel {
            get {
                return ResourceManager.GetString("ScriptFileLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to not found. Cannot run scripts..
        /// </summary>
        internal static string ScriptFolderNotFoundAddendum {
            get {
                return ResourceManager.GetString("ScriptFolderNotFoundAddendum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to not found. Cannot run scripts..
        /// </summary>
        internal static string ScriptFolderNotFoundMessage {
            get {
                return ResourceManager.GetString("ScriptFolderNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setup is disabled. To continue, please set DisableSetup to false in Web.config.
        /// </summary>
        internal static string SetupDisabledMessage {
            get {
                return ResourceManager.GetString("SetupDisabledMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  Note: This page shows some information that is helpful during setup and upgrades but for security it would be best not to show any information when the system is up to date. You can disable setup and suppress all information on this page by setting DisableSetup=true in Web.config. When you need to upgrade, you can set this back to false. If you are logged in as Administrator setup will run and you will be able to see this page even if it is disabled in Web.config so you can easily leave it disabled and just [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SetupEnabledMessage {
            get {
                return ResourceManager.GetString("SetupEnabledMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setup is complete, click the link below to go to the home page..
        /// </summary>
        internal static string SetupSuccessMessage {
            get {
                return ResourceManager.GetString("SetupSuccessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to mojoPortal Setup.
        /// </summary>
        internal static string SetupTitle {
            get {
                return ResourceManager.GetString("SetupTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome to mojoPortal Setup.
        /// </summary>
        internal static string SetupWelcomeMessage {
            get {
                return ResourceManager.GetString("SetupWelcomeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to to this:.
        /// </summary>
        internal static string ToThisLabel {
            get {
                return ResourceManager.GetString("ToThisLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trying To Create Database.
        /// </summary>
        internal static string TryingToCreateDatabase {
            get {
                return ResourceManager.GetString("TryingToCreateDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The system is not ble to make the needed schema changes using the current connection string. Please enter a connection string here with sufficient permission to alter the schema..
        /// </summary>
        internal static string UpgradeOverrideInstructions {
            get {
                return ResourceManager.GetString("UpgradeOverrideInstructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Upgrade Schema.
        /// </summary>
        internal static string UpgradeSchemaButton {
            get {
                return ResourceManager.GetString("UpgradeSchemaButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to mojoPortal Upgrade.
        /// </summary>
        internal static string UpgradeTitle {
            get {
                return ResourceManager.GetString("UpgradeTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version.
        /// </summary>
        internal static string VersionLabel {
            get {
                return ResourceManager.GetString("VersionLabel", resourceCulture);
            }
        }
    }
}
