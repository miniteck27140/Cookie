//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Character.Characteristic
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class CharacterSpellModification : NetworkType
    {
        
        public const short ProtocolId = 215;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private CharacterBaseCharacteristic m_value;
        
        public virtual CharacterBaseCharacteristic Value
        {
            get
            {
                return m_value;
            }
            set
            {
                m_value = value;
            }
        }
        
        private byte m_modificationType;
        
        public virtual byte ModificationType
        {
            get
            {
                return m_modificationType;
            }
            set
            {
                m_modificationType = value;
            }
        }
        
        private ushort m_spellId;
        
        public virtual ushort SpellId
        {
            get
            {
                return m_spellId;
            }
            set
            {
                m_spellId = value;
            }
        }
        
        public CharacterSpellModification(CharacterBaseCharacteristic value, byte modificationType, ushort spellId)
        {
            m_value = value;
            m_modificationType = modificationType;
            m_spellId = spellId;
        }
        
        public CharacterSpellModification()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_value.Serialize(writer);
            writer.WriteByte(m_modificationType);
            writer.WriteVarUhShort(m_spellId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_value = new CharacterBaseCharacteristic();
            m_value.Deserialize(reader);
            m_modificationType = reader.ReadByte();
            m_spellId = reader.ReadVarUhShort();
        }
    }
}