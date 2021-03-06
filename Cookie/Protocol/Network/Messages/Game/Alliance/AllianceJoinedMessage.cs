//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Alliance
{
    using Cookie.Protocol.Network.Types.Game.Context.Roleplay;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class AllianceJoinedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6402;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private AllianceInformations m_allianceInfo;
        
        public virtual AllianceInformations AllianceInfo
        {
            get
            {
                return m_allianceInfo;
            }
            set
            {
                m_allianceInfo = value;
            }
        }
        
        private bool m_enabled;
        
        public virtual bool Enabled
        {
            get
            {
                return m_enabled;
            }
            set
            {
                m_enabled = value;
            }
        }
        
        private uint m_leadingGuildId;
        
        public virtual uint LeadingGuildId
        {
            get
            {
                return m_leadingGuildId;
            }
            set
            {
                m_leadingGuildId = value;
            }
        }
        
        public AllianceJoinedMessage(AllianceInformations allianceInfo, bool enabled, uint leadingGuildId)
        {
            m_allianceInfo = allianceInfo;
            m_enabled = enabled;
            m_leadingGuildId = leadingGuildId;
        }
        
        public AllianceJoinedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_allianceInfo.Serialize(writer);
            writer.WriteBoolean(m_enabled);
            writer.WriteVarUhInt(m_leadingGuildId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_allianceInfo = new AllianceInformations();
            m_allianceInfo.Deserialize(reader);
            m_enabled = reader.ReadBoolean();
            m_leadingGuildId = reader.ReadVarUhInt();
        }
    }
}
