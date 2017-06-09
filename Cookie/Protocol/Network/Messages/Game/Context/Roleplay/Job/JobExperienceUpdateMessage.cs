//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.Job
{
    using Cookie.Protocol.Network.Types.Game.Context.Roleplay.Job;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class JobExperienceUpdateMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5654;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private JobExperience m_experiencesUpdate;
        
        public virtual JobExperience ExperiencesUpdate
        {
            get
            {
                return m_experiencesUpdate;
            }
            set
            {
                m_experiencesUpdate = value;
            }
        }
        
        public JobExperienceUpdateMessage(JobExperience experiencesUpdate)
        {
            m_experiencesUpdate = experiencesUpdate;
        }
        
        public JobExperienceUpdateMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_experiencesUpdate.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_experiencesUpdate = new JobExperience();
            m_experiencesUpdate.Deserialize(reader);
        }
    }
}