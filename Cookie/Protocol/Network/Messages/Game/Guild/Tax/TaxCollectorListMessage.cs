//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Guild.Tax
{
    using Cookie.Protocol.Network.Types.Game.Guild.Tax;
    using System.Collections.Generic;
    using Cookie.IO;
    
    
    public class TaxCollectorListMessage : AbstractTaxCollectorListMessage
    {
        
        public new const uint ProtocolId = 5930;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<TaxCollectorFightersInformation> m_fightersInformations;
        
        public virtual List<TaxCollectorFightersInformation> FightersInformations
        {
            get
            {
                return m_fightersInformations;
            }
            set
            {
                m_fightersInformations = value;
            }
        }
        
        private byte m_nbcollectorMax;
        
        public virtual byte NbcollectorMax
        {
            get
            {
                return m_nbcollectorMax;
            }
            set
            {
                m_nbcollectorMax = value;
            }
        }
        
        public TaxCollectorListMessage(List<TaxCollectorFightersInformation> fightersInformations, byte nbcollectorMax)
        {
            m_fightersInformations = fightersInformations;
            m_nbcollectorMax = nbcollectorMax;
        }
        
        public TaxCollectorListMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_fightersInformations.Count)));
            int fightersInformationsIndex;
            for (fightersInformationsIndex = 0; (fightersInformationsIndex < m_fightersInformations.Count); fightersInformationsIndex = (fightersInformationsIndex + 1))
            {
                TaxCollectorFightersInformation objectToSend = m_fightersInformations[fightersInformationsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteByte(m_nbcollectorMax);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            int fightersInformationsCount = reader.ReadUShort();
            int fightersInformationsIndex;
            m_fightersInformations = new System.Collections.Generic.List<TaxCollectorFightersInformation>();
            for (fightersInformationsIndex = 0; (fightersInformationsIndex < fightersInformationsCount); fightersInformationsIndex = (fightersInformationsIndex + 1))
            {
                TaxCollectorFightersInformation objectToAdd = new TaxCollectorFightersInformation();
                objectToAdd.Deserialize(reader);
                m_fightersInformations.Add(objectToAdd);
            }
            m_nbcollectorMax = reader.ReadByte();
        }
    }
}
