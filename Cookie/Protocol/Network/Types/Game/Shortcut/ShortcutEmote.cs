//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Shortcut
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ShortcutEmote : Shortcut
    {
        
        public new const short ProtocolId = 389;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_emoteId;
        
        public virtual sbyte EmoteId
        {
            get
            {
                return m_emoteId;
            }
            set
            {
                m_emoteId = value;
            }
        }
        
        public ShortcutEmote(sbyte emoteId)
        {
            m_emoteId = emoteId;
        }
        
        public ShortcutEmote()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(m_emoteId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_emoteId = reader.ReadSByte();
        }
    }
}
