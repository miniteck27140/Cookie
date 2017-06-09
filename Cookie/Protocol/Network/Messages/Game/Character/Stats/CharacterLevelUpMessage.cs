//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Character.Stats
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class CharacterLevelUpMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5670;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_newLevel;
        
        public virtual sbyte NewLevel
        {
            get
            {
                return m_newLevel;
            }
            set
            {
                m_newLevel = value;
            }
        }
        
        public CharacterLevelUpMessage(sbyte newLevel)
        {
            m_newLevel = newLevel;
        }
        
        public CharacterLevelUpMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteSByte(m_newLevel);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_newLevel = reader.ReadSByte();
        }
    }
}