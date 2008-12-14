
//                                      ______    ____  
//                                     |____  | "|__  | 
//                                      _   | |     | | 
//                                     | |  | |   __| | 
//                                     |_|  |_|  |_____| 
//
//  --------------------------------------------------- 
// |     _   ____     ___     ___    ____    ____      |
// |    (_) |___ \   / _ \   / _ \  |___ \  |___ \     |
// |    | |   __) | | | | | | | | |   __) |   __) |    |
// |    | |  / __/  | |_| | | |_| |  / __/   / __/     |
// |    |_| |_____|  \___/   \___/  |_____| |_____|    |
// |                                                   |
// |    AN ISO 20022 OPEN-SOURCE .NET CLASS LIBRARY    |
// |            FOR MESSAGING APPLICATIONS             |
// |                                                   |
// |        Copyright (C) 2008 Mauricio Leventer       |
// |                mleventer@i20022.com               |
// |                                                   |
//  ---------------------------------------------------
//
// L I C E N S E                                         
//                                                       
// This program is free software; you can redistribute it
// and/or modify it under the terms of the GNU General   
// Public License as published by the Free Software      
// Foundation; either version 2 of the License, or (at   
// your option) any later version.                       
//                                                       
// This program is distributed in the hope that it will  
// be useful, but WITHOUT ANY WARRANTY; without even the 
// implied warranty of MERCHANTABILITY or FITNESS FOR A  
// PARTICULAR PURPOSE. See the GNU General Public License
// for more details.                                     
//                                                       
// You should have received a copy of the GNU General    
// Public License along with this program; if not, write 
// to the Free Software Foundation, Inc.,                
// 59 Temple Place, Suite 330, Boston, MA                
// 02111-1307 USA.                                       
//                                                       
//
using System;
using System.Diagnostics;
using System.Xml.Serialization;


namespace i20022.tsmt00800103
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.008.001.03 name AmendmentRejectionNotificationV03 from Trade Services Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>AmdmntRjctnNtfctn</b> (Amendment Rejection Notification) of type AmendmentRejectionNotificationV03.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AmendmentRejectionNotificationV03 AmdmntRjctnNtfctn;
    }

    /// <summary>
    /// Class <b>AmendmentRejectionNotificationV03</b> (Amendment Rejection Notification V03).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class AmendmentRejectionNotificationV03
    {

        /// <summary>
        /// Element <b>NtfctnId</b> (Notification Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 NtfctnId;

        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public SimpleIdentificationInformation TxId;

        /// <summary>
        /// Element <b>EstblishdBaselnId</b> (Estblishd Baseline Identification) of type DocumentIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public DocumentIdentification3 EstblishdBaselnId;

        /// <summary>
        /// Element <b>TxSts</b> (Transaction Status) of type TransactionStatus4.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public TransactionStatus4 TxSts;

        /// <summary>
        /// Element <b>UsrTxRef</b> (User Transaction Reference) of type array of DocumentIdentification5.
        /// </summary>
        [XmlElementAttribute( "UsrTxRef", Order = 4 )]
        public DocumentIdentification5[] UsrTxRef;

        /// <summary>
        /// Element <b>DltaRptRef</b> (Dlta Report Reference) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public MessageIdentification1 DltaRptRef;

        /// <summary>
        /// Element <b>RjctdAmdmntNb</b> (Rejected Amendment Number) of type Count1.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public Count1 RjctdAmdmntNb;

        /// <summary>
        /// Element <b>Initr</b> (Initiator) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public BICIdentification1 Initr;

        /// <summary>
        /// Element <b>RjctnRsn</b> (Rejection Reason) of type RejectionReason1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public RejectionReason1Choice RjctnRsn;

        /// <summary>
        /// Element <b>ReqForActn</b> (Request For Action) of type PendingActivity2.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public PendingActivity2 ReqForActn;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class MessageIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime CreDtTm;
    }

    /// <summary>
    /// Class <b>PendingActivity2</b> (Pending Activity 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class PendingActivity2
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type Action2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public Action2Code Tp;

        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Desc;
    }

    /// <summary>
    /// Enumeration <b>Action2Code</b> (Action 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public enum Action2Code
    {

        /// <summary>
        /// <b>SBTW - Submit Twin</b>.
        /// </summary>
        SBTW,

        /// <summary>
        /// <b>RSTW - Re Submit Twin</b>.
        /// </summary>
        RSTW,

        /// <summary>
        /// <b>RSBS - Re Submit Baseline</b>.
        /// </summary>
        RSBS,

        /// <summary>
        /// <b>ARDM - Accept Or Reject Data Set Mis Matches</b>.
        /// </summary>
        ARDM,

        /// <summary>
        /// <b>ARCS - Accept Or Reject Change Of Status</b>.
        /// </summary>
        ARCS,

        /// <summary>
        /// <b>ARES - Accept Or Reject Extension Of Status</b>.
        /// </summary>
        ARES,

        /// <summary>
        /// <b>WAIT - Wait For Baseline Established</b>.
        /// </summary>
        WAIT,

        /// <summary>
        /// <b>UPDT - Update And Resend</b>.
        /// </summary>
        UPDT,

        /// <summary>
        /// <b>SBDS - Submit Data Set</b>.
        /// </summary>
        SBDS,

        /// <summary>
        /// <b>ARBA - Accept Or Reject Baseline Amendment</b>.
        /// </summary>
        ARBA,

        /// <summary>
        /// <b>ARRO - Accept Or Reject Baseline And Role</b>.
        /// </summary>
        ARRO,

        /// <summary>
        /// <b>CINR - Check Invoice Reference</b>.
        /// </summary>
        CINR,
    }

    /// <summary>
    /// Class <b>RejectedElement1</b> (Rejected Element 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class RejectedElement1
    {

        /// <summary>
        /// Element <b>ElmtSeqNb</b> (Element Sequence Number) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public decimal ElmtSeqNb;

        /// <summary>
        /// Element <b>IndvRjctnRsn</b> (Individual Rejection Reason) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string IndvRjctnRsn;
    }

    /// <summary>
    /// Class <b>Reason2</b> (Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class Reason2
    {

        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Desc;
    }

    /// <summary>
    /// Class <b>RejectionReason1Choice</b> (Rejection Reason 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class RejectionReason1Choice
    {

        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// This element can be:
        ///  GblRjctnRsn of type Reason2 
        ///  RjctdElmt of type RejectedElement1 
        /// </summary>
        [XmlElementAttribute( "GblRjctnRsn", typeof( Reason2 ), Order = 0 )]
        [XmlElementAttribute( "RjctdElmt", typeof( RejectedElement1 ), Order = 0 )]
        public object[] Items;
    }

    /// <summary>
    /// Class <b>Count1</b> (Count 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class Count1
    {

        /// <summary>
        /// Element <b>Nb</b> (Number) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public decimal Nb;
    }

    /// <summary>
    /// Class <b>BICIdentification1</b> (BICIdentification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class BICIdentification1
    {

        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BIC;
    }

    /// <summary>
    /// Class <b>DocumentIdentification5</b> (Document Identification 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class DocumentIdentification5
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>IdIssr</b> (Identification Issuer) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public BICIdentification1 IdIssr;
    }

    /// <summary>
    /// Class <b>TransactionStatus4</b> (Transaction Status 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class TransactionStatus4
    {

        /// <summary>
        /// Element <b>Sts</b> (Status) of type BaselineStatus3Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public BaselineStatus3Code Sts;
    }

    /// <summary>
    /// Enumeration <b>BaselineStatus3Code</b> (Baseline Status 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public enum BaselineStatus3Code
    {

        /// <summary>
        /// <b>PROP - Proposed</b>.
        /// </summary>
        PROP,

        /// <summary>
        /// <b>CLSD - Closed</b>.
        /// </summary>
        CLSD,

        /// <summary>
        /// <b>PMTC - Partially Matched</b>.
        /// </summary>
        PMTC,

        /// <summary>
        /// <b>ESTD - Established</b>.
        /// </summary>
        ESTD,

        /// <summary>
        /// <b>ACTV - Active</b>.
        /// </summary>
        ACTV,

        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,

        /// <summary>
        /// <b>AMRQ - Amendment Requested</b>.
        /// </summary>
        AMRQ,

        /// <summary>
        /// <b>RARQ - Re Activate Requested</b>.
        /// </summary>
        RARQ,

        /// <summary>
        /// <b>CLRQ - Close Requested</b>.
        /// </summary>
        CLRQ,

        /// <summary>
        /// <b>SCRQ - Complete Requested</b>.
        /// </summary>
        SCRQ,

        /// <summary>
        /// <b>SERQ - Status Extension Requested</b>.
        /// </summary>
        SERQ,

        /// <summary>
        /// <b>DARQ - Data Set Acceptance Requested</b>.
        /// </summary>
        DARQ,
    }

    /// <summary>
    /// Class <b>DocumentIdentification3</b> (Document Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class DocumentIdentification3
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Vrsn</b> (Version) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal Vrsn;
    }

    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.008.001.03" )]
    public class SimpleIdentificationInformation
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;
    }
}