﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ORM.Tests
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// AuditMasterMasterObject.
    /// </summary>
    // *** Start programmer edit section *** (AuditMasterMasterObject CustomAttributes)

    // *** End programmer edit section *** (AuditMasterMasterObject CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class AuditMasterMasterObject : ICSSoft.STORMNET.DataObject
    {
        
        private string fLogin;
        
        private string fName;
        
        private string fSurname;
        
        // *** Start programmer edit section *** (AuditMasterMasterObject CustomMembers)

        // *** End programmer edit section *** (AuditMasterMasterObject CustomMembers)

        
        /// <summary>
        /// Login.
        /// </summary>
        // *** Start programmer edit section *** (AuditMasterMasterObject.Login CustomAttributes)

        // *** End programmer edit section *** (AuditMasterMasterObject.Login CustomAttributes)
        [StrLen(255)]
        public virtual string Login
        {
            get
            {
                // *** Start programmer edit section *** (AuditMasterMasterObject.Login Get start)

                // *** End programmer edit section *** (AuditMasterMasterObject.Login Get start)
                string result = this.fLogin;
                // *** Start programmer edit section *** (AuditMasterMasterObject.Login Get end)

                // *** End programmer edit section *** (AuditMasterMasterObject.Login Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditMasterMasterObject.Login Set start)

                // *** End programmer edit section *** (AuditMasterMasterObject.Login Set start)
                this.fLogin = value;
                // *** Start programmer edit section *** (AuditMasterMasterObject.Login Set end)

                // *** End programmer edit section *** (AuditMasterMasterObject.Login Set end)
            }
        }
        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (AuditMasterMasterObject.Name CustomAttributes)

        // *** End programmer edit section *** (AuditMasterMasterObject.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (AuditMasterMasterObject.Name Get start)

                // *** End programmer edit section *** (AuditMasterMasterObject.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (AuditMasterMasterObject.Name Get end)

                // *** End programmer edit section *** (AuditMasterMasterObject.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditMasterMasterObject.Name Set start)

                // *** End programmer edit section *** (AuditMasterMasterObject.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (AuditMasterMasterObject.Name Set end)

                // *** End programmer edit section *** (AuditMasterMasterObject.Name Set end)
            }
        }
        
        /// <summary>
        /// Surname.
        /// </summary>
        // *** Start programmer edit section *** (AuditMasterMasterObject.Surname CustomAttributes)

        // *** End programmer edit section *** (AuditMasterMasterObject.Surname CustomAttributes)
        [StrLen(255)]
        public virtual string Surname
        {
            get
            {
                // *** Start programmer edit section *** (AuditMasterMasterObject.Surname Get start)

                // *** End programmer edit section *** (AuditMasterMasterObject.Surname Get start)
                string result = this.fSurname;
                // *** Start programmer edit section *** (AuditMasterMasterObject.Surname Get end)

                // *** End programmer edit section *** (AuditMasterMasterObject.Surname Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditMasterMasterObject.Surname Set start)

                // *** End programmer edit section *** (AuditMasterMasterObject.Surname Set start)
                this.fSurname = value;
                // *** Start programmer edit section *** (AuditMasterMasterObject.Surname Set end)

                // *** End programmer edit section *** (AuditMasterMasterObject.Surname Set end)
            }
        }
        
        /// <summary>
        /// NameSurname.
        /// </summary>
        // *** Start programmer edit section *** (AuditMasterMasterObject.NameSurname CustomAttributes)

        // *** End programmer edit section *** (AuditMasterMasterObject.NameSurname CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [StrLen(255)]
        public virtual string NameSurname
        {
            get
            {
                // *** Start programmer edit section *** (AuditMasterMasterObject.NameSurname Get)
                return null;
                // *** End programmer edit section *** (AuditMasterMasterObject.NameSurname Get)
            }
            set
            {
                // *** Start programmer edit section *** (AuditMasterMasterObject.NameSurname Set)

                // *** End programmer edit section *** (AuditMasterMasterObject.NameSurname Set)
            }
        }
    }
}