//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Context.Roleplay.Party
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class NamedPartyTeamWithOutcome : NetworkType
    {
        
        public const short ProtocolId = 470;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private NamedPartyTeam m_team;
        
        public virtual NamedPartyTeam Team
        {
            get
            {
                return m_team;
            }
            set
            {
                m_team = value;
            }
        }
        
        private ushort m_outcome;
        
        public virtual ushort Outcome
        {
            get
            {
                return m_outcome;
            }
            set
            {
                m_outcome = value;
            }
        }
        
        public NamedPartyTeamWithOutcome(NamedPartyTeam team, ushort outcome)
        {
            m_team = team;
            m_outcome = outcome;
        }
        
        public NamedPartyTeamWithOutcome()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_team.Serialize(writer);
            writer.WriteVarUhShort(m_outcome);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_team = new NamedPartyTeam();
            m_team.Deserialize(reader);
            m_outcome = reader.ReadVarUhShort();
        }
    }
}
