//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Guild
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GuildPaddockTeleportRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5957;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_paddockId;
        
        public virtual int PaddockId
        {
            get
            {
                return m_paddockId;
            }
            set
            {
                m_paddockId = value;
            }
        }
        
        public GuildPaddockTeleportRequestMessage(int paddockId)
        {
            m_paddockId = paddockId;
        }
        
        public GuildPaddockTeleportRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteInt(m_paddockId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_paddockId = reader.ReadInt();
        }
    }
}