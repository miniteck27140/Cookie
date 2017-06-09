//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Inventory.Items
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class MimicryObjectEraseRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6457;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_hostUID;
        
        public virtual uint HostUID
        {
            get
            {
                return m_hostUID;
            }
            set
            {
                m_hostUID = value;
            }
        }
        
        private sbyte m_hostPos;
        
        public virtual sbyte HostPos
        {
            get
            {
                return m_hostPos;
            }
            set
            {
                m_hostPos = value;
            }
        }
        
        public MimicryObjectEraseRequestMessage(uint hostUID, sbyte hostPos)
        {
            m_hostUID = hostUID;
            m_hostPos = hostPos;
        }
        
        public MimicryObjectEraseRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhInt(m_hostUID);
            writer.WriteSByte(m_hostPos);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_hostUID = reader.ReadVarUhInt();
            m_hostPos = reader.ReadSByte();
        }
    }
}