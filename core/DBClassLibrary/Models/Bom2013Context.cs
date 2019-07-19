using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBClassLibrary.Models
{
    public partial class Bom2013Context : DbContext
    {
        public Bom2013Context()
        {
        }

        public Bom2013Context(DbContextOptions<Bom2013Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AbnData> AbnData { get; set; }
        public virtual DbSet<AbnTitle> AbnTitle { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<BackFlow> BackFlow { get; set; }
        public virtual DbSet<BackFlow2> BackFlow2 { get; set; }
        public virtual DbSet<BfSta> BfSta { get; set; }
        public virtual DbSet<BfSta2> BfSta2 { get; set; }
        public virtual DbSet<Bom> Bom { get; set; }
        public virtual DbSet<BomWareH> BomWareH { get; set; }
        public virtual DbSet<CmbSteelCtrlDetail> CmbSteelCtrlDetail { get; set; }
        public virtual DbSet<CmbSteelCtrlTitle> CmbSteelCtrlTitle { get; set; }
        public virtual DbSet<CmdClass> CmdClass { get; set; }
        public virtual DbSet<Comsup> Comsup { get; set; }
        public virtual DbSet<ComsupDep> ComsupDep { get; set; }
        public virtual DbSet<ComsupWork> ComsupWork { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<CutDistBom> CutDistBom { get; set; }
        public virtual DbSet<CutDistDetail> CutDistDetail { get; set; }
        public virtual DbSet<CutDistShape> CutDistShape { get; set; }
        public virtual DbSet<CutDistTitle> CutDistTitle { get; set; }
        public virtual DbSet<DepClass> DepClass { get; set; }
        public virtual DbSet<DepFbright> DepFbright { get; set; }
        public virtual DbSet<DepUser> DepUser { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DfSelListUdb> DfSelListUdb { get; set; }
        public virtual DbSet<Eng> Eng { get; set; }
        public virtual DbSet<EngDiv> EngDiv { get; set; }
        public virtual DbSet<EngMemType> EngMemType { get; set; }
        public virtual DbSet<EngOld> EngOld { get; set; }
        public virtual DbSet<EngOwner> EngOwner { get; set; }
        public virtual DbSet<EngPic> EngPic { get; set; }
        public virtual DbSet<EngPicDelete> EngPicDelete { get; set; }
        public virtual DbSet<EngPicWareH> EngPicWareH { get; set; }
        public virtual DbSet<EngRight> EngRight { get; set; }
        public virtual DbSet<EngTier> EngTier { get; set; }
        public virtual DbSet<EngTombstone> EngTombstone { get; set; }
        public virtual DbSet<FavoriteForm> FavoriteForm { get; set; }
        public virtual DbSet<FbForm> FbForm { get; set; }
        public virtual DbSet<FbFormHistory> FbFormHistory { get; set; }
        public virtual DbSet<FbRepdDetail> FbRepdDetail { get; set; }
        public virtual DbSet<FbRepdTitle> FbRepdTitle { get; set; }
        public virtual DbSet<Field> Field { get; set; }
        public virtual DbSet<FieldWork> FieldWork { get; set; }
        public virtual DbSet<Flow> Flow { get; set; }
        public virtual DbSet<FlowData> FlowData { get; set; }
        public virtual DbSet<Form> Form { get; set; }
        public virtual DbSet<FormGroup> FormGroup { get; set; }
        public virtual DbSet<FormRight> FormRight { get; set; }
        public virtual DbSet<Ipright> Ipright { get; set; }
        public virtual DbSet<Kg> Kg { get; set; }
        public virtual DbSet<Main> Main { get; set; }
        public virtual DbSet<Making> Making { get; set; }
        public virtual DbSet<MakingWareH> MakingWareH { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MaterialEng> MaterialEng { get; set; }
        public virtual DbSet<MaxfbqtyTest> MaxfbqtyTest { get; set; }
        public virtual DbSet<MemBack> MemBack { get; set; }
        public virtual DbSet<MemBack2> MemBack2 { get; set; }
        public virtual DbSet<MemComsup> MemComsup { get; set; }
        public virtual DbSet<MemDiv> MemDiv { get; set; }
        public virtual DbSet<MemSta> MemSta { get; set; }
        public virtual DbSet<MemSta2> MemSta2 { get; set; }
        public virtual DbSet<MemType> MemType { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Member2> Member2 { get; set; }
        public virtual DbSet<Member2WareH> Member2WareH { get; set; }
        public virtual DbSet<MemberFlag> MemberFlag { get; set; }
        public virtual DbSet<MemberWareH> MemberWareH { get; set; }
        public virtual DbSet<ModifyLog> ModifyLog { get; set; }
        public virtual DbSet<MtEng> MtEng { get; set; }
        public virtual DbSet<MtExtraD> MtExtraD { get; set; }
        public virtual DbSet<MtExtraT> MtExtraT { get; set; }
        public virtual DbSet<MtMaterial> MtMaterial { get; set; }
        public virtual DbSet<MtOverTimeBlast> MtOverTimeBlast { get; set; }
        public virtual DbSet<MtPurchD> MtPurchD { get; set; }
        public virtual DbSet<MtPurchT> MtPurchT { get; set; }
        public virtual DbSet<MtRecvD> MtRecvD { get; set; }
        public virtual DbSet<MtRecvT> MtRecvT { get; set; }
        public virtual DbSet<MtRejD> MtRejD { get; set; }
        public virtual DbSet<MtRejT> MtRejT { get; set; }
        public virtual DbSet<MtReturnD> MtReturnD { get; set; }
        public virtual DbSet<MtReturnT> MtReturnT { get; set; }
        public virtual DbSet<MtStockD> MtStockD { get; set; }
        public virtual DbSet<MtStockDbk> MtStockDbk { get; set; }
        public virtual DbSet<MtStockLog> MtStockLog { get; set; }
        public virtual DbSet<MtStockT> MtStockT { get; set; }
        public virtual DbSet<MtStockTbk> MtStockTbk { get; set; }
        public virtual DbSet<MtTransD> MtTransD { get; set; }
        public virtual DbSet<MtTransT> MtTransT { get; set; }
        public virtual DbSet<NcrBom> NcrBom { get; set; }
        public virtual DbSet<NcrDuty> NcrDuty { get; set; }
        public virtual DbSet<NcrFailWorkRptDetail> NcrFailWorkRptDetail { get; set; }
        public virtual DbSet<NcrFailWorkRptTitle> NcrFailWorkRptTitle { get; set; }
        public virtual DbSet<NcrFault> NcrFault { get; set; }
        public virtual DbSet<NcrFaultName> NcrFaultName { get; set; }
        public virtual DbSet<NcrFeedBack> NcrFeedBack { get; set; }
        public virtual DbSet<NcrImprov> NcrImprov { get; set; }
        public virtual DbSet<NcrIssueUnit> NcrIssueUnit { get; set; }
        public virtual DbSet<NcrProposal> NcrProposal { get; set; }
        public virtual DbSet<NcrStatus> NcrStatus { get; set; }
        public virtual DbSet<NcrStrategy> NcrStrategy { get; set; }
        public virtual DbSet<NcrStrategyStatus> NcrStrategyStatus { get; set; }
        public virtual DbSet<NcrTitle> NcrTitle { get; set; }
        public virtual DbSet<NcrType> NcrType { get; set; }
        public virtual DbSet<NcrTypeName> NcrTypeName { get; set; }
        public virtual DbSet<NcrWorkStation> NcrWorkStation { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }
        public virtual DbSet<OwnerEmp> OwnerEmp { get; set; }
        public virtual DbSet<PaintClass> PaintClass { get; set; }
        public virtual DbSet<PicClass> PicClass { get; set; }
        public virtual DbSet<PicRule> PicRule { get; set; }
        public virtual DbSet<PicType> PicType { get; set; }
        public virtual DbSet<PicVer> PicVer { get; set; }
        public virtual DbSet<PilotSpDetail> PilotSpDetail { get; set; }
        public virtual DbSet<PilotSpTitle> PilotSpTitle { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<Qa> Qa { get; set; }
        public virtual DbSet<QaFeedback> QaFeedback { get; set; }
        public virtual DbSet<QaRece> QaRece { get; set; }
        public virtual DbSet<QaStatus> QaStatus { get; set; }
        public virtual DbSet<Qaexp> Qaexp { get; set; }
        public virtual DbSet<QaexpType> QaexpType { get; set; }
        public virtual DbSet<RGrpUserSup> RGrpUserSup { get; set; }
        public virtual DbSet<Right> Right { get; set; }
        public virtual DbSet<Rpt> Rpt { get; set; }
        public virtual DbSet<SignFlow> SignFlow { get; set; }
        public virtual DbSet<SpFunSta> SpFunSta { get; set; }
        public virtual DbSet<SpLedger> SpLedger { get; set; }
        public virtual DbSet<SpfunRpt> SpfunRpt { get; set; }
        public virtual DbSet<SpfunTitle> SpfunTitle { get; set; }
        public virtual DbSet<SprangeDetail> SprangeDetail { get; set; }
        public virtual DbSet<SprangeMem> SprangeMem { get; set; }
        public virtual DbSet<SprangeTitle> SprangeTitle { get; set; }
        public virtual DbSet<Spsite> Spsite { get; set; }
        public virtual DbSet<SteelClass> SteelClass { get; set; }
        public virtual DbSet<StsEng> StsEng { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<TBom> TBom { get; set; }
        public virtual DbSet<TBomOutExcel> TBomOutExcel { get; set; }
        public virtual DbSet<TChkComsupWork> TChkComsupWork { get; set; }
        public virtual DbSet<TChkFbsaveData> TChkFbsaveData { get; set; }
        public virtual DbSet<TChkMsg> TChkMsg { get; set; }
        public virtual DbSet<TEngPic> TEngPic { get; set; }
        public virtual DbSet<TFbFormDg> TFbFormDg { get; set; }
        public virtual DbSet<TFeedBackSave> TFeedBackSave { get; set; }
        public virtual DbSet<TFunNonBud> TFunNonBud { get; set; }
        public virtual DbSet<TGetFormData> TGetFormData { get; set; }
        public virtual DbSet<TImpBomFrmWbBom> TImpBomFrmWbBom { get; set; }
        public virtual DbSet<TImpDiv> TImpDiv { get; set; }
        public virtual DbSet<TImpMaking> TImpMaking { get; set; }
        public virtual DbSet<TImpMember> TImpMember { get; set; }
        public virtual DbSet<TImportComSup> TImportComSup { get; set; }
        public virtual DbSet<TImportFb> TImportFb { get; set; }
        public virtual DbSet<TMemCut> TMemCut { get; set; }
        public virtual DbSet<TMemProc1> TMemProc1 { get; set; }
        public virtual DbSet<TMemProc2> TMemProc2 { get; set; }
        public virtual DbSet<TMemProdDtl> TMemProdDtl { get; set; }
        public virtual DbSet<TMemRange> TMemRange { get; set; }
        public virtual DbSet<TMtrlLedgerBeDel> TMtrlLedgerBeDel { get; set; }
        public virtual DbSet<TOutExcel> TOutExcel { get; set; }
        public virtual DbSet<TProdProgress> TProdProgress { get; set; }
        public virtual DbSet<TQaqry> TQaqry { get; set; }
        public virtual DbSet<TRptBomQry> TRptBomQry { get; set; }
        public virtual DbSet<TRptMakingQry> TRptMakingQry { get; set; }
        public virtual DbSet<TRptMemUseQry> TRptMemUseQry { get; set; }
        public virtual DbSet<TRptRang> TRptRang { get; set; }
        public virtual DbSet<TTestBom> TTestBom { get; set; }
        public virtual DbSet<TVuBomMakingQry> TVuBomMakingQry { get; set; }
        public virtual DbSet<Tgroup> Tgroup { get; set; }
        public virtual DbSet<TransBomDetail> TransBomDetail { get; set; }
        public virtual DbSet<TransBomTitle> TransBomTitle { get; set; }
        public virtual DbSet<Tuser> Tuser { get; set; }
        public virtual DbSet<Usage> Usage { get; set; }
        public virtual DbSet<UsageEng> UsageEng { get; set; }
        public virtual DbSet<UserBehaviorLog> UserBehaviorLog { get; set; }
        public virtual DbSet<UserEngRight> UserEngRight { get; set; }
        public virtual DbSet<WebLogin> WebLogin { get; set; }
        public virtual DbSet<Weld> Weld { get; set; }
        public virtual DbSet<Work> Work { get; set; }
        public virtual DbSet<WorkList> WorkList { get; set; }
        public virtual DbSet<Workflow> Workflow { get; set; }
        public virtual DbSet<製作圖發圖簽收單位> 製作圖發圖簽收單位 { get; set; }
        public virtual DbSet<製作圖發圖簽收明細> 製作圖發圖簽收明細 { get; set; }
        public virtual DbSet<製作圖發圖總表Title> 製作圖發圖總表Title { get; set; }
        public virtual DbSet<製作圖發圖總表圖號明細> 製作圖發圖總表圖號明細 { get; set; }

        // Unable to generate entity type for table 'dbo.p1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ttabc'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Mt_material_xls'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Mt_ImportMsg'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.T_MemFbData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Eng0103OwnerData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NanSan_BT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NanSan_BK'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Mt_Stock_xls'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Mt_data_xls'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MemDiv_Test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SpCheckup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ComsupWork_test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.製作圖發圖單位'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._TestMak_test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Board'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Form_Group_New'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Form_Group_OrgV1'. Please see the warning messages.



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AbnData>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CmemId })
                    .HasName("PK_AbnData2");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.DefF1)
                    .IsRequired()
                    .HasColumnName("def_f1")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.DefF2)
                    .IsRequired()
                    .HasColumnName("def_f2")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.DefF3)
                    .IsRequired()
                    .HasColumnName("def_f3")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.DefF4)
                    .IsRequired()
                    .HasColumnName("def_f4")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.DefF5)
                    .IsRequired()
                    .HasColumnName("def_f5")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.DefF6)
                    .IsRequired()
                    .HasColumnName("def_f6")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.DefF7)
                    .IsRequired()
                    .HasColumnName("def_f7")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.DefF8)
                    .IsRequired()
                    .HasColumnName("def_f8")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.ImemQty)
                    .HasColumnName("imem_qty")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumOne]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumOne]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumOne] AS 1
");

                entity.HasOne(d => d.AbnTitle)
                    .WithMany(p => p.AbnData)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_AbnData_AbnTitle");
            });

            modelBuilder.Entity<AbnTitle>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId })
                    .HasName("PK_AbnTitle2");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.CusrName)
                    .IsRequired()
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DefF1)
                    .HasColumnName("def_f1")
                    .HasMaxLength(20)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.DefF2)
                    .HasColumnName("def_f2")
                    .HasMaxLength(20)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.DefF3)
                    .HasColumnName("def_f3")
                    .HasMaxLength(20)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.DefF4)
                    .HasColumnName("def_f4")
                    .HasMaxLength(20)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.DefF5)
                    .HasColumnName("def_f5")
                    .HasMaxLength(20)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.DefF6)
                    .HasColumnName("def_f6")
                    .HasMaxLength(20)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.DefF7)
                    .HasColumnName("def_f7")
                    .HasMaxLength(20)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.DefF8)
                    .HasColumnName("def_f8")
                    .HasMaxLength(20)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Descp)
                    .IsRequired()
                    .HasColumnName("descp")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.PaintKey);

                entity.ToTable("area");

                entity.Property(e => e.PaintKey)
                    .HasColumnName("paintKey")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Paint1)
                    .HasColumnName("paint1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Paint2)
                    .HasColumnName("paint2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnName("result")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BackFlow>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.CformId, e.Iorder });

                entity.ToTable("Back_Flow");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CformId)
                    .HasColumnName("cform_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Iorder).HasColumnName("iorder");

                entity.Property(e => e.BSurface1).HasColumnName("bSurface1");

                entity.Property(e => e.BSurface2).HasColumnName("bSurface2");

                entity.Property(e => e.BWet)
                    .HasColumnName("bWet")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16);

                entity.Property(e => e.IprtQty)
                    .HasColumnName("iprt_qty")
                    .HasColumnType("decimal(9, 4)");

                entity.Property(e => e.ProDate)
                    .HasColumnName("pro_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reflux).HasColumnName("reflux");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.BackFlow)
                    .HasForeignKey(d => new { d.CengId, d.CformId })
                    .HasConstraintName("FK_Back_Flow_Fb_form");
            });

            modelBuilder.Entity<BackFlow2>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.CformId, e.Iorder });

                entity.ToTable("Back_Flow2");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CformId)
                    .HasColumnName("cform_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Iorder).HasColumnName("iorder");

                entity.Property(e => e.BSurface1).HasColumnName("bSurface1");

                entity.Property(e => e.BSurface2).HasColumnName("bSurface2");

                entity.Property(e => e.BWet)
                    .HasColumnName("bWet")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.CdivName)
                    .IsRequired()
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16);

                entity.Property(e => e.IprtQty)
                    .HasColumnName("iprt_qty")
                    .HasColumnType("decimal(9, 4)");

                entity.Property(e => e.ProDate)
                    .HasColumnName("pro_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reflux).HasColumnName("reflux");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.BackFlow2)
                    .HasForeignKey(d => new { d.CengId, d.CformId })
                    .HasConstraintName("FK_Back_Flow2_Fb_form");
            });

            modelBuilder.Entity<BfSta>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.CworkId, e.RepId });

                entity.ToTable("BF_Sta");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CworkId)
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.EprtDate)
                    .HasColumnName("eprt_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.IprtQty)
                    .HasColumnName("iprt_qty")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.SprtDate)
                    .HasColumnName("sprt_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.HasOne(d => d.FbRepdDetail)
                    .WithMany(p => p.BfSta)
                    .HasForeignKey(d => new { d.CengId, d.RepId, d.CmemId })
                    .HasConstraintName("FK_BF_Sta_FbRepd_Detail");
            });

            modelBuilder.Entity<BfSta2>(entity =>
            {
                entity.HasKey(e => new { e.Repid, e.CengId, e.CmemId, e.CworkId, e.CdivName });

                entity.ToTable("BF_Sta2");

                entity.Property(e => e.Repid)
                    .HasColumnName("repid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CworkId)
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.EprtDate)
                    .HasColumnName("eprt_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.IprtQty)
                    .HasColumnName("iprt_qty")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.SprtDate)
                    .HasColumnName("sprt_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");
            });

            modelBuilder.Entity<Bom>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.CmakId })
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IOrder).HasColumnName("iOrder");

                entity.Property(e => e.IbomQty).HasColumnName("ibom_qty");

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Bom)
                    .HasForeignKey(d => new { d.CengId, d.CmakId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bom_Making");

                entity.HasOne(d => d.CNavigation)
                    .WithMany(p => p.Bom)
                    .HasForeignKey(d => new { d.CengId, d.CmemId })
                    .HasConstraintName("FK_Bom_Member");
            });

            modelBuilder.Entity<BomWareH>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.CmakId, e.VerName })
                    .HasName("PK_Bom_WardH")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Bom_WareH");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VerName)
                    .HasColumnName("verName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IOrder).HasColumnName("iOrder");

                entity.Property(e => e.IbomQty).HasColumnName("ibom_qty");

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MemberWareH)
                    .WithMany(p => p.BomWareH)
                    .HasForeignKey(d => new { d.CengId, d.CmemId, d.VerName })
                    .HasConstraintName("FK_Bom_WareH_Member_WareH");
            });

            modelBuilder.Entity<CmbSteelCtrlDetail>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.IOrder });

                entity.ToTable("CmbSteelCtrl_Detail");

                entity.Property(e => e.RepId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IOrder).HasColumnName("iOrder");

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CclassId)
                    .HasColumnName("cclass_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdescrip)
                    .HasColumnName("cdescrip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Cspec)
                    .HasColumnName("cspec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Dim1)
                    .HasColumnName("dim1")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Dim2)
                    .HasColumnName("dim2")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Dim3)
                    .HasColumnName("dim3")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Dim4)
                    .HasColumnName("dim4")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Iqty).HasColumnName("iqty");

                entity.Property(e => e.NWeight)
                    .HasColumnName("nWeight")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.NmakLen)
                    .HasColumnName("nmak_len")
                    .HasColumnType("decimal(9, 1)");

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.CmbSteelCtrlDetail)
                    .HasForeignKey(d => d.RepId)
                    .HasConstraintName("FK_CmbSteelCtrl_Detail_CmbSteelCtrl_Title");
            });

            modelBuilder.Entity<CmbSteelCtrlTitle>(entity =>
            {
                entity.HasKey(e => e.RepId);

                entity.ToTable("CmbSteelCtrl_Title");

                entity.Property(e => e.RepId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CSite)
                    .IsRequired()
                    .HasColumnName("cSite")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmdClass>(entity =>
            {
                entity.HasKey(e => e.CengClass)
                    .HasName("cmd_class_cclass_id");

                entity.ToTable("cmd_class");

                entity.HasIndex(e => e.CclassName)
                    .HasName("cmd_class_cclass_nam")
                    .IsUnique();

                entity.Property(e => e.CengClass)
                    .HasColumnName("ceng_class")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CclassName)
                    .IsRequired()
                    .HasColumnName("cclass_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintId)
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comsup>(entity =>
            {
                entity.HasKey(e => e.CsupId)
                    .HasName("PK_TComsup");

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CLeader)
                    .HasColumnName("cLeader")
                    .HasMaxLength(6);

                entity.Property(e => e.Caddress)
                    .HasColumnName("caddress")
                    .HasMaxLength(40);

                entity.Property(e => e.CaddressF)
                    .HasColumnName("caddress_f")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Cfax)
                    .HasColumnName("cfax")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CsupDesp)
                    .HasColumnName("csup_desp")
                    .HasMaxLength(40);

                entity.Property(e => e.CsupName)
                    .IsRequired()
                    .HasColumnName("csup_name")
                    .HasMaxLength(20);

                entity.Property(e => e.CsupNum)
                    .HasColumnName("csup_num")
                    .HasMaxLength(4);

                entity.Property(e => e.CsupSna)
                    .IsRequired()
                    .HasColumnName("csup_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CsupType)
                    .HasColumnName("csup_type")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Ctel1)
                    .HasColumnName("ctel1")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Ctel2)
                    .HasColumnName("ctel2")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComsupDep>(entity =>
            {
                entity.HasKey(e => new { e.CsupId, e.CDepId })
                    .HasName("PK_ComsupUnit");

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Iorder).HasColumnName("iorder");
            });

            modelBuilder.Entity<ComsupWork>(entity =>
            {
                entity.HasKey(e => new { e.CworkId, e.CsupId });

                entity.Property(e => e.CworkId)
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.HasOne(d => d.Csup)
                    .WithMany(p => p.ComsupWork)
                    .HasForeignKey(d => d.CsupId)
                    .HasConstraintName("FK_ComsupWork_Comsup");

                entity.HasOne(d => d.Cwork)
                    .WithMany(p => p.ComsupWork)
                    .HasForeignKey(d => d.CworkId)
                    .HasConstraintName("FK_ComsupWork_Work");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.HasKey(e => e.CcontraId)
                    .HasName("contract_ccontra_id");

                entity.HasIndex(e => e.CcontraName)
                    .HasName("contract_ccontra_na")
                    .IsUnique();

                entity.Property(e => e.CcontraId)
                    .HasColumnName("ccontra_id")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CcontraName)
                    .IsRequired()
                    .HasColumnName("ccontra_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CutDistBom>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CdivName, e.CmemId, e.CmakId });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Bweight)
                    .HasColumnName("bweight")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.CSpec)
                    .IsRequired()
                    .HasColumnName("c_spec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongId)
                    .IsRequired()
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .IsRequired()
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CmakDesp)
                    .IsRequired()
                    .HasColumnName("cmak_desp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .IsRequired()
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .IsRequired()
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CuseId)
                    .IsRequired()
                    .HasColumnName("cuse_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Nlen)
                    .HasColumnName("nlen")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.HasOne(d => d.CutDistTitle)
                    .WithMany(p => p.CutDistBom)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_CutDistBom_CutDistTitle");
            });

            modelBuilder.Entity<CutDistDetail>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.ItemNo, e.ShapNo });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .IsRequired()
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CmakId)
                    .IsRequired()
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .IsRequired()
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.HasOne(d => d.CutDistTitle)
                    .WithMany(p => p.CutDistDetail)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_CutDistDetail_CutDistTitle");

                entity.HasOne(d => d.CutDistShape)
                    .WithMany(p => p.CutDistDetail)
                    .HasForeignKey(d => new { d.CengId, d.RepId, d.ShapNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CutDistDetail_CutDistShape");

                entity.HasOne(d => d.CutDistBom)
                    .WithMany(p => p.CutDistDetail)
                    .HasForeignKey(d => new { d.CengId, d.RepId, d.CdivName, d.CmemId, d.CmakId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CutDistDetail_CutDistBom");
            });

            modelBuilder.Entity<CutDistShape>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.ShapNo });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bweight)
                    .HasColumnName("bweight")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.CSpec)
                    .IsRequired()
                    .HasColumnName("c_spec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .IsRequired()
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LossRate).HasColumnName("lossRate");

                entity.Property(e => e.Nlen)
                    .HasColumnName("nlen")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.NlenRem)
                    .HasColumnName("nlen_Rem")
                    .HasColumnType("decimal(9, 1)");

                entity.HasOne(d => d.CutDistTitle)
                    .WithMany(p => p.CutDistShape)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_CutDistShape_CutDistTitle");
            });

            modelBuilder.Entity<CutDistTitle>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId })
                    .HasName("PK_CutDist");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.Cdescp)
                    .IsRequired()
                    .HasColumnName("cdescp")
                    .HasMaxLength(50);

                entity.Property(e => e.EdgeLen).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.LenRem).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Lossrate)
                    .HasColumnName("lossrate")
                    .HasDefaultValueSql("((3))");
            });

            modelBuilder.Entity<DepClass>(entity =>
            {
                entity.HasKey(e => e.IClass);

                entity.Property(e => e.IClass)
                    .HasColumnName("iClass")
                    .ValueGeneratedNever();

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(10)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");
            });

            modelBuilder.Entity<DepFbright>(entity =>
            {
                entity.HasKey(e => new { e.CDepId, e.CworkId })
                    .HasName("unit_pk");

                entity.ToTable("DepFBRight");

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CworkId)
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepUser>(entity =>
            {
                entity.HasKey(e => new { e.CDepId, e.CusrName });

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IClass)
                    .HasColumnName("iClass")
                    .HasDefaultValueSql("((5))");

                entity.HasOne(d => d.CDep)
                    .WithMany(p => p.DepUser)
                    .HasForeignKey(d => d.CDepId)
                    .HasConstraintName("FK_DepUser_Department");

                entity.HasOne(d => d.CusrNameNavigation)
                    .WithMany(p => p.DepUser)
                    .HasForeignKey(d => d.CusrName)
                    .HasConstraintName("FK_DepUser_TUser");

                entity.HasOne(d => d.IClassNavigation)
                    .WithMany(p => p.DepUser)
                    .HasForeignKey(d => d.IClass)
                    .HasConstraintName("FK_DepUser_DepClass");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.CDepId);

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CDepName)
                    .IsRequired()
                    .HasColumnName("cDep_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CDepSna)
                    .IsRequired()
                    .HasColumnName("cDep_Sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SendMailType).HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");
            });

            modelBuilder.Entity<DfSelListUdb>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("dfSelList_Udb");

                entity.Property(e => e.CId)
                    .HasColumnName("cId")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(50);

                entity.Property(e => e.Db)
                    .HasColumnName("DB")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Eng>(entity =>
            {
                entity.HasKey(e => e.CengId);

                entity.HasIndex(e => e.CengId)
                    .HasName("cmd_ceng_no")
                    .IsUnique();

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BagrmPrice).HasColumnName("bagrm_price");

                entity.Property(e => e.BbldgArea).HasColumnName("bbldg_area");

                entity.Property(e => e.BbldgGround).HasColumnName("bbldg_ground");

                entity.Property(e => e.BengGround).HasColumnName("beng_ground");

                entity.Property(e => e.BengWeight).HasColumnName("beng_weight");

                entity.Property(e => e.CPicPath)
                    .HasColumnName("cPicPath")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSort)
                    .HasColumnName("cSort")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CadviserId)
                    .HasColumnName("cadviser_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CbuildId)
                    .HasColumnName("cbuild_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CcontraId)
                    .IsRequired()
                    .HasColumnName("ccontra_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CdirectId)
                    .HasColumnName("cdirect_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CengClass)
                    .IsRequired()
                    .HasColumnName("ceng_class")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CengName)
                    .IsRequired()
                    .HasColumnName("ceng_name")
                    .HasMaxLength(60);

                entity.Property(e => e.CengQaname)
                    .HasColumnName("ceng_QAName")
                    .HasMaxLength(60);

                entity.Property(e => e.CengSna)
                    .IsRequired()
                    .HasColumnName("ceng_sna")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CflowId)
                    .IsRequired()
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CkgId)
                    .IsRequired()
                    .HasColumnName("ckg_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cowner)
                    .HasColumnName("cowner")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CownerId)
                    .HasColumnName("cowner_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintDph)
                    .HasColumnName("cpaint_dph")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintFb)
                    .HasColumnName("cpaint_fb")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintId)
                    .IsRequired()
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintSp)
                    .HasColumnName("cpaint_sp")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Dclose)
                    .HasColumnName("dclose")
                    .HasColumnType("datetime");

                entity.Property(e => e.DcompDate)
                    .HasColumnName("dcomp_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dgetdeal)
                    .HasColumnName("dgetdeal")
                    .HasColumnType("datetime");

                entity.Property(e => e.DstartDate)
                    .HasColumnName("dstart_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExamEngName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastEditDate).HasColumnType("datetime");

                entity.Property(e => e.LbomFb).HasColumnName("lbom_fb");

                entity.Property(e => e.LbomO).HasColumnName("lbom_o");

                entity.Property(e => e.LmctFb).HasColumnName("lmct_fb");

                entity.Property(e => e.LmctO).HasColumnName("lmct_o");

                entity.HasOne(d => d.CengClassNavigation)
                    .WithMany(p => p.Eng)
                    .HasForeignKey(d => d.CengClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eng_cmd_class");
            });

            modelBuilder.Entity<EngDiv>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CdivName });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BdivOrder).HasColumnName("bdiv_order");

                entity.Property(e => e.Cfied0700)
                    .HasColumnName("cfied_0700")
                    .HasMaxLength(4)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[Str3Dash]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[Str3Dash]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[Str3Dash] as '---'
");

                entity.Property(e => e.Cfied0800)
                    .HasColumnName("cfied_0800")
                    .HasMaxLength(4)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[Str3Dash]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[Str3Dash]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[Str3Dash] as '---'
");

                entity.Property(e => e.Cfied1000)
                    .HasColumnName("cfied_1000")
                    .HasMaxLength(4)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[Str3Dash]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[Str3Dash]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[Str3Dash] as '---'
");

                entity.Property(e => e.Csup0700)
                    .HasColumnName("csup_0700")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[Str3Dash]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[Str3Dash]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[Str3Dash] as '---'
");

                entity.Property(e => e.Csup0800)
                    .HasColumnName("csup_0800")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[Str3Dash]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[Str3Dash]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[Str3Dash] as '---'
");

                entity.Property(e => e.Csup1000)
                    .HasColumnName("csup_1000")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[Str3Dash]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[Str3Dash]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[Str3Dash] as '---'
");

                entity.Property(e => e.Descrip)
                    .HasColumnName("descrip")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngMemType>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CbelongId });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CDescp)
                    .HasColumnName("cDescp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CEngBelongDesc)
                    .HasColumnName("cEngBelongDesc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpaintId)
                    .IsRequired()
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngOld>(entity =>
            {
                entity.HasKey(e => e.CengName);

                entity.ToTable("Eng_old");

                entity.HasIndex(e => e.CengId)
                    .HasName("cmd_ceng_no_old")
                    .IsUnique();

                entity.Property(e => e.CengName)
                    .HasColumnName("ceng_name")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.BagrmPrice).HasColumnName("bagrm_price");

                entity.Property(e => e.BbldgArea).HasColumnName("bbldg_area");

                entity.Property(e => e.BbldgGround).HasColumnName("bbldg_ground");

                entity.Property(e => e.BengGround).HasColumnName("beng_ground");

                entity.Property(e => e.BengWeight).HasColumnName("beng_weight");

                entity.Property(e => e.CPicPath)
                    .HasColumnName("cPicPath")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSort)
                    .HasColumnName("cSort")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CadviserId)
                    .HasColumnName("cadviser_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CbuildId)
                    .HasColumnName("cbuild_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CcontraId)
                    .IsRequired()
                    .HasColumnName("ccontra_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CdirectId)
                    .HasColumnName("cdirect_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CengClass)
                    .IsRequired()
                    .HasColumnName("ceng_class")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SB')");

                entity.Property(e => e.CengId)
                    .IsRequired()
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('99SB999')");

                entity.Property(e => e.CengQaname)
                    .HasColumnName("ceng_QAName")
                    .HasMaxLength(60)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CengSna)
                    .IsRequired()
                    .HasColumnName("ceng_sna")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CflowId)
                    .IsRequired()
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A1')");

                entity.Property(e => e.CkgId)
                    .IsRequired()
                    .HasColumnName("ckg_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cowner)
                    .HasColumnName("cowner")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CownerId)
                    .HasColumnName("cowner_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintDph)
                    .HasColumnName("cpaint_dph")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintFb)
                    .HasColumnName("cpaint_fb")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintId)
                    .IsRequired()
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintSp)
                    .HasColumnName("cpaint_sp")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Dclose)
                    .HasColumnName("dclose")
                    .HasColumnType("datetime");

                entity.Property(e => e.DcompDate)
                    .HasColumnName("dcomp_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dgetdeal)
                    .HasColumnName("dgetdeal")
                    .HasColumnType("datetime");

                entity.Property(e => e.DstartDate)
                    .HasColumnName("dstart_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastEditDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.LbomFb).HasColumnName("lbom_fb");

                entity.Property(e => e.LbomO).HasColumnName("lbom_o");

                entity.Property(e => e.LmctFb).HasColumnName("lmct_fb");

                entity.Property(e => e.LmctO).HasColumnName("lmct_o");
            });

            modelBuilder.Entity<EngOwner>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.COwnerId, e.Contact })
                    .HasName("PK_SetEngOwner");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.COwnerId)
                    .HasColumnName("cOwner_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(10);

                entity.Property(e => e.CNote)
                    .HasColumnName("cNote")
                    .HasMaxLength(40);

                entity.HasOne(d => d.C)
                    .WithMany(p => p.EngOwner)
                    .HasForeignKey(d => new { d.COwnerId, d.Contact })
                    .HasConstraintName("FK_EngOwner_OwnerEmp");
            });

            modelBuilder.Entity<EngPic>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemPic });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CPicClass)
                    .HasColumnName("cPicClass")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CPicType)
                    .HasColumnName("cPicType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CUserName)
                    .HasColumnName("cUser_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DUpd)
                    .HasColumnName("dUpd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DVer)
                    .HasColumnName("dVer")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dcheck)
                    .HasColumnName("dcheck")
                    .HasColumnType("datetime");

                entity.Property(e => e.DependPic)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Lcheck)
                    .HasColumnName("lcheck")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.VerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngPicDelete>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemPic });

                entity.ToTable("EngPic_Delete");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CPicClass)
                    .HasColumnName("cPicClass")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CPicType)
                    .HasColumnName("cPicType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CUserName)
                    .HasColumnName("cUser_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DUpd)
                    .HasColumnName("dUpd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DVer)
                    .HasColumnName("dVer")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dcheck)
                    .HasColumnName("dcheck")
                    .HasColumnType("datetime");

                entity.Property(e => e.DependPic)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Lcheck).HasColumnName("lcheck");

                entity.Property(e => e.VerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngPicWareH>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemPic, e.VerName });

                entity.ToTable("EngPic_WareH");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CPicClass)
                    .HasColumnName("cPicClass")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CPicType)
                    .HasColumnName("cPicType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CUserName)
                    .HasColumnName("cUser_name")
                    .HasMaxLength(10);

                entity.Property(e => e.CVerUser)
                    .HasColumnName("cVerUser")
                    .HasMaxLength(10);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpd)
                    .HasColumnName("dUpd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DVer)
                    .HasColumnName("dVer")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EngRight>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CId });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CId)
                    .HasColumnName("cId")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.EngRight)
                    .HasForeignKey(d => d.CId)
                    .HasConstraintName("FK_EngRight_Comsup");

                entity.HasOne(d => d.Ceng)
                    .WithMany(p => p.EngRight)
                    .HasForeignKey(d => d.CengId)
                    .HasConstraintName("FK_EngRight_Eng");
            });

            modelBuilder.Entity<EngTier>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CtierName });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .HasColumnName("descrip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ceng)
                    .WithMany(p => p.EngTier)
                    .HasForeignKey(d => d.CengId)
                    .HasConstraintName("FK_EngTier_Eng");
            });

            modelBuilder.Entity<EngTombstone>(entity =>
            {
                entity.HasKey(e => e.CengId)
                    .HasName("PKDEL_Eng_Tombstone_ceng_id");

                entity.ToTable("Eng_Tombstone");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DeletionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FavoriteForm>(entity =>
            {
                entity.HasKey(e => new { e.CusrName, e.Inum, e.CfrmgroupId });

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Inum).HasColumnName("inum");

                entity.Property(e => e.CfrmgroupId)
                    .HasColumnName("cfrmgroup_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FbForm>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CformId });

                entity.ToTable("Fb_form");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CformId)
                    .HasColumnName("cform_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Atdate)
                    .HasColumnName("atdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDepId)
                    .IsRequired()
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CNote)
                    .HasColumnName("cNote")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CfiedId)
                    .IsRequired()
                    .HasColumnName("cfied_id")
                    .HasMaxLength(4);

                entity.Property(e => e.CsupId)
                    .IsRequired()
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CworkId)
                    .IsRequired()
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FbDate)
                    .HasColumnName("fb_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsBf)
                    .HasColumnName("IsBF")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CDep)
                    .WithMany(p => p.FbForm)
                    .HasForeignKey(d => d.CDepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fb_form_Department");

                entity.HasOne(d => d.Cfied)
                    .WithMany(p => p.FbForm)
                    .HasForeignKey(d => d.CfiedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fb_form_Field");

                entity.HasOne(d => d.Csup)
                    .WithMany(p => p.FbForm)
                    .HasForeignKey(d => d.CsupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fb_form_Comsup");

                entity.HasOne(d => d.Cwork)
                    .WithMany(p => p.FbForm)
                    .HasForeignKey(d => d.CworkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fb_form_Work");
            });

            modelBuilder.Entity<FbFormHistory>(entity =>
            {
                entity.HasKey(e => e.CFormId);

                entity.ToTable("Fb_formHistory");

                entity.Property(e => e.CFormId)
                    .HasColumnName("cForm_Id")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AtDate).HasColumnType("datetime");

                entity.Property(e => e.CEngId)
                    .IsRequired()
                    .HasColumnName("cEng_Id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CFiedId)
                    .IsRequired()
                    .HasColumnName("cFied_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CSupId)
                    .IsRequired()
                    .HasColumnName("cSup_Id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CUnitId)
                    .IsRequired()
                    .HasColumnName("cUnit_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CUserName)
                    .IsRequired()
                    .HasColumnName("cUser_Name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CWorkId)
                    .IsRequired()
                    .HasColumnName("cWork_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FbDate)
                    .HasColumnName("Fb_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<FbRepdDetail>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CmemId })
                    .HasName("PK_AbnData");

                entity.ToTable("FbRepd_Detail");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BSurface1).HasColumnName("bSurface1");

                entity.Property(e => e.BSurfae2).HasColumnName("bSurfae2");

                entity.Property(e => e.BWet)
                    .HasColumnName("bWet")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.CbelongId)
                    .IsRequired()
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .IsRequired()
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .IsRequired()
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsStp).HasColumnName("IsSTP");

                entity.HasOne(d => d.FbRepdTitle)
                    .WithMany(p => p.FbRepdDetail)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_FbRepd_Detail_FbRepd_Title");
            });

            modelBuilder.Entity<FbRepdTitle>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId })
                    .HasName("PK_AbnTitle");

                entity.ToTable("FbRepd_Title");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Cdate)
                    .HasColumnName("CDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.CusrName)
                    .IsRequired()
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Descp)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Ftype).HasColumnName("FType");
            });

            modelBuilder.Entity<Field>(entity =>
            {
                entity.HasKey(e => e.CfiedId);

                entity.Property(e => e.CfiedId)
                    .HasColumnName("cfied_id")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.CDefDep)
                    .HasColumnName("cDef_dep")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CfiedDesp)
                    .HasColumnName("cfied_desp")
                    .HasMaxLength(50);

                entity.Property(e => e.CfiedName)
                    .HasColumnName("cfied_name")
                    .HasMaxLength(20);

                entity.Property(e => e.CfiedSna)
                    .HasColumnName("cfied_sna")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<FieldWork>(entity =>
            {
                entity.HasKey(e => new { e.CfiedId, e.CworkId });

                entity.Property(e => e.CfiedId)
                    .HasColumnName("cfied_id")
                    .HasMaxLength(4);

                entity.Property(e => e.CworkId)
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.HasOne(d => d.Cfied)
                    .WithMany(p => p.FieldWork)
                    .HasForeignKey(d => d.CfiedId)
                    .HasConstraintName("FK_FieldWork_Field");

                entity.HasOne(d => d.Cwork)
                    .WithMany(p => p.FieldWork)
                    .HasForeignKey(d => d.CworkId)
                    .HasConstraintName("FK_FieldWork_Work");
            });

            modelBuilder.Entity<Flow>(entity =>
            {
                entity.HasKey(e => e.CflowId);

                entity.Property(e => e.CflowId)
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CflowDesp)
                    .IsRequired()
                    .HasColumnName("cflow_desp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CflowName)
                    .IsRequired()
                    .HasColumnName("cflow_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlowData>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Flow_Data");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.HasKey(e => e.CfrmName)
                    .HasName("form_cfrm_name")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.CfrmDesp)
                    .HasName("cfrm_desp")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.CfrmName)
                    .HasColumnName("cfrm_name")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Atdate)
                    .HasColumnName("atdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPrgName)
                    .HasColumnName("cPrgName")
                    .HasMaxLength(6);

                entity.Property(e => e.CfrmDesp)
                    .IsRequired()
                    .HasColumnName("cfrm_desp")
                    .HasMaxLength(40);

                entity.Property(e => e.CfrmNo)
                    .HasColumnName("cfrmNo")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CfrmVer)
                    .HasColumnName("cfrm_ver")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CfrmgroupId)
                    .HasColumnName("cfrmgroup_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cnote)
                    .HasColumnName("cnote")
                    .HasMaxLength(200);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Mtdate)
                    .HasColumnName("mtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rpt).HasColumnName("rpt");

                entity.HasOne(d => d.Cfrmgroup)
                    .WithMany(p => p.Form)
                    .HasForeignKey(d => d.CfrmgroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Form_Form_Group");
            });

            modelBuilder.Entity<FormGroup>(entity =>
            {
                entity.HasKey(e => e.CfrmgroupId)
                    .HasName("PK_Form_Group_1");

                entity.ToTable("Form_Group");

                entity.Property(e => e.CfrmgroupId)
                    .HasColumnName("cfrmgroup_id")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CNo)
                    .HasColumnName("cNo")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CParent)
                    .HasColumnName("cParent")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CfrmgroupName)
                    .IsRequired()
                    .HasColumnName("cfrmgroup_name")
                    .HasMaxLength(20);

                entity.Property(e => e.Cid)
                    .HasColumnName("CId")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ILevel).HasColumnName("iLevel");

                entity.Property(e => e.ISort).HasColumnName("iSort");
            });

            modelBuilder.Entity<FormRight>(entity =>
            {
                entity.HasKey(e => new { e.CgrpName, e.CfrmName, e.CRight })
                    .HasName("PK_Right");

                entity.Property(e => e.CgrpName)
                    .HasColumnName("cgrp_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CfrmName)
                    .HasColumnName("cfrm_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CRight)
                    .HasColumnName("cRight")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CRightNavigation)
                    .WithMany(p => p.FormRight)
                    .HasForeignKey(d => d.CRight)
                    .HasConstraintName("FK_TRight_RightDesc");

                entity.HasOne(d => d.CfrmNameNavigation)
                    .WithMany(p => p.FormRight)
                    .HasForeignKey(d => d.CfrmName)
                    .HasConstraintName("FK_TRight_Form");

                entity.HasOne(d => d.CgrpNameNavigation)
                    .WithMany(p => p.FormRight)
                    .HasForeignKey(d => d.CgrpName)
                    .HasConstraintName("FK_TRight_TGroup");
            });

            modelBuilder.Entity<Ipright>(entity =>
            {
                entity.HasKey(e => e.IpAddress);

                entity.ToTable("IPRight");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ip1)
                    .HasColumnName("IP1")
                    .HasMaxLength(3);

                entity.Property(e => e.Ip2)
                    .HasColumnName("IP2")
                    .HasMaxLength(3);

                entity.Property(e => e.Ip3)
                    .HasColumnName("IP3")
                    .HasMaxLength(3);

                entity.Property(e => e.Ip4)
                    .HasColumnName("IP4")
                    .HasMaxLength(3);

                entity.Property(e => e.Note).HasMaxLength(100);
            });

            modelBuilder.Entity<Kg>(entity =>
            {
                entity.HasKey(e => e.CkgId)
                    .HasName("factore_fact_id");

                entity.Property(e => e.CkgId)
                    .HasColumnName("ckg_id")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CkgName)
                    .IsRequired()
                    .HasColumnName("ckg_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Main>(entity =>
            {
                entity.HasKey(e => new { e.CmainId, e.CengId })
                    .HasName("main_pk_main");

                entity.Property(e => e.CmainId)
                    .HasColumnName("cmain_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cdescrip)
                    .IsRequired()
                    .HasColumnName("cdescrip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .IsRequired()
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Making>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmakId });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BcutA1)
                    .HasColumnName("bcut_a1")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.BcutA2)
                    .HasColumnName("bcut_a2")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.BsurfaceA).HasColumnName("bsurface_a");

                entity.Property(e => e.BsurfaceB).HasColumnName("bsurface_b");

                entity.Property(e => e.Bweight).HasColumnName("bweight");

                entity.Property(e => e.CSiteId)
                    .HasColumnName("cSiteId")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[Str3Dash]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[Str3Dash]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[Str3Dash] as '---'
");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cdescrip)
                    .HasColumnName("cdescrip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CmainId)
                    .HasColumnName("cmain_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmakDesp)
                    .HasColumnName("cmak_desp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintId)
                    .IsRequired()
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Cspec)
                    .HasColumnName("cspec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CuseId)
                    .HasColumnName("cuse_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Lbend)
                    .IsRequired()
                    .HasColumnName("lbend")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.Lcal1).HasColumnName("lcal1");

                entity.Property(e => e.Lcal2).HasColumnName("lcal2");

                entity.Property(e => e.Lcut)
                    .IsRequired()
                    .HasColumnName("lcut")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.Ledit).HasColumnName("ledit");

                entity.Property(e => e.Lhole)
                    .IsRequired()
                    .HasColumnName("lhole")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.Linternal)
                    .IsRequired()
                    .HasColumnName("linternal")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.Lmodify)
                    .IsRequired()
                    .HasColumnName("lmodify")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.Lnc)
                    .IsRequired()
                    .HasColumnName("lnc")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.Lpic)
                    .HasColumnName("lpic")
                    .HasMaxLength(2)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Lprint)
                    .IsRequired()
                    .HasColumnName("lprint")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.Lregular)
                    .IsRequired()
                    .HasColumnName("lregular")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.Lsketch)
                    .IsRequired()
                    .HasColumnName("lsketch")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.Ltemplate)
                    .IsRequired()
                    .HasColumnName("ltemplate")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.Lweld)
                    .IsRequired()
                    .HasColumnName("lweld")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.NcutW)
                    .HasColumnName("ncut_w")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.NmakLen)
                    .HasColumnName("nmak_len")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.NmakWidth)
                    .HasColumnName("nmakWidth")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Nweight)
                    .HasColumnName("nweight")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CdescripNavigation)
                    .WithMany(p => p.Making)
                    .HasForeignKey(d => d.Cdescrip)
                    .HasConstraintName("FK_Making_Profile");

                entity.HasOne(d => d.Ceng)
                    .WithMany(p => p.Making)
                    .HasForeignKey(d => d.CengId)
                    .HasConstraintName("FK_Making_Eng");
            });

            modelBuilder.Entity<MakingWareH>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmakId, e.VerName, e.CmemPic })
                    .HasName("PK_Making_WareH_1");

                entity.ToTable("Making_WareH");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_Id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_Id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BcutA1).HasColumnName("bcut_a1");

                entity.Property(e => e.BcutA2).HasColumnName("bcut_a2");

                entity.Property(e => e.BsurfaceA).HasColumnName("bsurface_a");

                entity.Property(e => e.BsurfaceB).HasColumnName("bsurface_b");

                entity.Property(e => e.Bweight).HasColumnName("bweight");

                entity.Property(e => e.Cdescrip)
                    .HasColumnName("cdescrip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_Name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CmainId)
                    .HasColumnName("cmain_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmakDesp)
                    .HasColumnName("cmak_desp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintId)
                    .IsRequired()
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cspec)
                    .HasColumnName("cspec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CuseId)
                    .HasColumnName("cuse_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Lcal1).HasColumnName("lcal1");

                entity.Property(e => e.Lcal2).HasColumnName("lcal2");

                entity.Property(e => e.Ledit).HasColumnName("ledit");

                entity.Property(e => e.Lmodify).HasColumnName("lmodify");

                entity.Property(e => e.NcutW)
                    .HasColumnName("ncut_w")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.NmakLen)
                    .HasColumnName("nmak_len")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.NmakWidth)
                    .HasColumnName("nmakWidth")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Nweight)
                    .HasColumnName("nweight")
                    .HasColumnType("decimal(9, 1)");

                entity.HasOne(d => d.EngPicWareH)
                    .WithMany(p => p.MakingWareH)
                    .HasForeignKey(d => new { d.CengId, d.CmemPic, d.VerName })
                    .HasConstraintName("FK_Making_WareH_EngPic_WareH");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.CmaName);

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CmaSpec)
                    .HasColumnName("cma_spec")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nsort).HasColumnName("nsort");
            });

            modelBuilder.Entity<MaterialEng>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmaName })
                    .HasName("PK_Material_Eng");

                entity.ToTable("Material_eng");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CmaNameNavigation)
                    .WithMany(p => p.MaterialEng)
                    .HasForeignKey(d => d.CmaName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Material_eng_Material");
            });

            modelBuilder.Entity<MaxfbqtyTest>(entity =>
            {
                entity.HasKey(e => e.Qty)
                    .HasName("PK__MAXFBQTY");

                entity.ToTable("_MAXFBQTY_test");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<MemBack>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.CformId, e.Iorder });

                entity.ToTable("Mem_back");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CformId)
                    .HasColumnName("cform_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Iorder).HasColumnName("iorder");

                entity.Property(e => e.BSurface1).HasColumnName("bSurface1");

                entity.Property(e => e.BSurface2).HasColumnName("bSurface2");

                entity.Property(e => e.BWet)
                    .HasColumnName("bWet")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.IprtQty)
                    .HasColumnName("iprt_qty")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.ProDate)
                    .HasColumnName("pro_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.MemBack)
                    .HasForeignKey(d => new { d.CengId, d.CformId })
                    .HasConstraintName("FK_Mem_back_Fb_form");
            });

            modelBuilder.Entity<MemBack2>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.CformId, e.Iorder });

                entity.ToTable("Mem_back2");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CformId)
                    .HasColumnName("cform_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Iorder).HasColumnName("iorder");

                entity.Property(e => e.BSurface1).HasColumnName("bSurface1");

                entity.Property(e => e.BSurface2).HasColumnName("bSurface2");

                entity.Property(e => e.BWet)
                    .HasColumnName("bWet")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.CdivName)
                    .IsRequired()
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.IprtQty)
                    .HasColumnName("iprt_qty")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.ProDate)
                    .HasColumnName("pro_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.MemBack2)
                    .HasForeignKey(d => new { d.CengId, d.CformId })
                    .HasConstraintName("FK_Mem_back2_Fb_form");
            });

            modelBuilder.Entity<MemComsup>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CsupId, e.CmemId, e.CworkId });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CworkId)
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ImemQty)
                    .HasColumnName("imem_qty")
                    .HasColumnType("decimal(9, 4)");

                entity.HasOne(d => d.Csup)
                    .WithMany(p => p.MemComsup)
                    .HasForeignKey(d => d.CsupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemComsup_Comsup");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.MemComsup)
                    .HasForeignKey(d => new { d.CengId, d.CmemId })
                    .HasConstraintName("FK_MemComsup_Member");
            });

            modelBuilder.Entity<MemDiv>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.CdivName })
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cfied0700)
                    .HasColumnName("cfied_0700")
                    .HasMaxLength(4);

                entity.Property(e => e.Cfied0800)
                    .HasColumnName("cfied_0800")
                    .HasMaxLength(4);

                entity.Property(e => e.Cfied1000)
                    .HasColumnName("cfied_1000")
                    .HasMaxLength(4);

                entity.Property(e => e.Csup0700)
                    .HasColumnName("csup_0700")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Csup0800)
                    .HasColumnName("csup_0800")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Csup1000)
                    .HasColumnName("csup_1000")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Dtlayout)
                    .HasColumnName("dtlayout")
                    .HasColumnType("datetime");

                entity.Property(e => e.GoalDate)
                    .HasColumnName("goal_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdivQty).HasColumnName("idiv_qty");

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.MemDiv)
                    .HasForeignKey(d => new { d.CengId, d.CdivName })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemDiv_EngDiv");

                entity.HasOne(d => d.CNavigation)
                    .WithMany(p => p.MemDiv)
                    .HasForeignKey(d => new { d.CengId, d.CmemId })
                    .HasConstraintName("FK_Member_MemDiv");
            });

            modelBuilder.Entity<MemSta>(entity =>
            {
                entity.HasKey(e => new { e.CworkId, e.CengId, e.CmemId })
                    .HasName("mem_sta_pk_msta");

                entity.ToTable("mem_sta");

                entity.Property(e => e.CworkId)
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EprtDate)
                    .HasColumnName("eprt_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IprtQty)
                    .HasColumnName("iprt_qty")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.SprtDate)
                    .HasColumnName("sprt_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MemSta2>(entity =>
            {
                entity.HasKey(e => new { e.CdivName, e.CworkId, e.CengId, e.CmemId })
                    .HasName("mem_sta2_pk_msta2");

                entity.ToTable("mem_sta2");

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CworkId)
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EprtDate)
                    .HasColumnName("eprt_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IprtQty)
                    .HasColumnName("iprt_qty")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.SprtDate)
                    .HasColumnName("sprt_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MemType>(entity =>
            {
                entity.HasKey(e => e.CbelongId)
                    .HasName("belong_cbelong_id")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasColumnName("cName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongName)
                    .IsRequired()
                    .HasColumnName("cbelong_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CsubjectId)
                    .IsRequired()
                    .HasColumnName("csubject_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Nsort).HasColumnName("nsort");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BmcutA1).HasColumnName("bmcut_a1");

                entity.Property(e => e.BmcutA2).HasColumnName("bmcut_a2");

                entity.Property(e => e.BmcutW).HasColumnName("bmcut_w");

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CflowId)
                    .IsRequired()
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CljoinId)
                    .HasColumnName("cljoin_id")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.CmainId)
                    .HasColumnName("cmain_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintId)
                    .IsRequired()
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CrjoinId)
                    .HasColumnName("crjoin_id")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .IsRequired()
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DBomNew)
                    .HasColumnName("dBomNew")
                    .HasColumnType("datetime");

                entity.Property(e => e.DBomUpd)
                    .HasColumnName("dBomUpd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DssNote).HasMaxLength(40);

                entity.Property(e => e.Dtbhin)
                    .HasColumnName("dtbhin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dtemplate)
                    .HasColumnName("dtemplate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dtlayout)
                    .HasColumnName("dtlayout")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dtrawin)
                    .HasColumnName("dtrawin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dtruler)
                    .HasColumnName("dtruler")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");

                entity.Property(e => e.Lbom).HasColumnName("lbom");

                entity.Property(e => e.Lplant).HasColumnName("lplant");

                entity.Property(e => e.PcsNote).HasMaxLength(40);

                entity.Property(e => e.QasNote).HasMaxLength(40);

                entity.Property(e => e.SpData)
                    .HasColumnName("sp_data")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpDraw)
                    .HasColumnName("sp_draw")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpProd)
                    .HasColumnName("sp_prod")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpSite)
                    .HasColumnName("sp_site")
                    .HasColumnType("datetime");

                entity.Property(e => e.StsNote).HasMaxLength(40);

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => new { d.CengId, d.CbelongId })
                    .HasConstraintName("FK_Member_EngMemType");

                entity.HasOne(d => d.CNavigation)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => new { d.CengId, d.CmemPic })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Member_EngPic");

                entity.HasOne(d => d.C1)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => new { d.CengId, d.CtierName })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_EngTier");
            });

            modelBuilder.Entity<Member2>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BGrossSiteWet)
                    .HasColumnName("bGrossSiteWet")
                    .HasColumnType("decimal(13, 5)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.BGrossWet)
                    .HasColumnName("bGrossWet")
                    .HasColumnType("decimal(13, 5)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.BMctSiteWet)
                    .HasColumnName("bMctSiteWet")
                    .HasColumnType("decimal(13, 5)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.BMctWet)
                    .HasColumnName("bMctWet")
                    .HasColumnType("decimal(13, 5)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.BPicSiteWet)
                    .HasColumnName("bPicSiteWet")
                    .HasColumnType("decimal(13, 5)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.BPicWet)
                    .HasColumnName("bPicWet")
                    .HasColumnType("decimal(13, 5)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.BmsiteA1)
                    .HasColumnName("bmsite_a1")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.BmsiteA2)
                    .HasColumnName("bmsite_a2")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.Bmsurface1)
                    .HasColumnName("bmsurface1")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.Bmsurface2)
                    .HasColumnName("bmsurface2")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.CSpec)
                    .HasColumnName("c_spec")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CmaName)
                    .IsRequired()
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GrossSiteWet)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.GrossWet)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.LReCalWetArea)
                    .HasColumnName("lReCalWetArea")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.Ledit).HasColumnName("ledit");

                entity.Property(e => e.MctSiteWet)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.MctWet)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.PicSiteWet)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.PicWet)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.HasOne(d => d.C)
                    .WithOne(p => p.Member2)
                    .HasForeignKey<Member2>(d => new { d.CengId, d.CmemId })
                    .HasConstraintName("FK_Member2_Member");
            });

            modelBuilder.Entity<Member2WareH>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.VerName });

                entity.ToTable("Member2_WareH");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BmsiteA1).HasColumnName("bmsite_a1");

                entity.Property(e => e.BmsiteA2).HasColumnName("bmsite_a2");

                entity.Property(e => e.Bmsurface1).HasColumnName("bmsurface1");

                entity.Property(e => e.Bmsurface2).HasColumnName("bmsurface2");

                entity.Property(e => e.CSpec)
                    .HasColumnName("c_spec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossSiteWet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.GrossWet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ledit).HasColumnName("ledit");

                entity.Property(e => e.MctSiteWet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.MctWet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.PicSiteWet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.PicWet).HasColumnType("decimal(9, 1)");

                entity.HasOne(d => d.MemberWareH)
                    .WithOne(p => p.Member2WareH)
                    .HasForeignKey<Member2WareH>(d => new { d.CengId, d.CmemId, d.VerName })
                    .HasConstraintName("FK_Member2_WareH_Member_WareH");
            });

            modelBuilder.Entity<MemberFlag>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId });

                entity.ToTable("Member_Flag");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.RptChg)
                    .IsRequired()
                    .HasColumnName("Rpt_Chg")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.RptLayout)
                    .HasColumnName("Rpt_Layout")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.RptNcr)
                    .IsRequired()
                    .HasColumnName("Rpt_Ncr")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.RptRfb)
                    .IsRequired()
                    .HasColumnName("Rpt_RFb")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.RptSp)
                    .HasColumnName("Rpt_SP")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.HasOne(d => d.C)
                    .WithOne(p => p.MemberFlag)
                    .HasForeignKey<MemberFlag>(d => new { d.CengId, d.CmemId })
                    .HasConstraintName("FK_Member_Flag_Member");
            });

            modelBuilder.Entity<MemberWareH>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.VerName });

                entity.ToTable("Member_WareH");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BmcutA1).HasColumnName("bmcut_a1");

                entity.Property(e => e.BmcutA2).HasColumnName("bmcut_a2");

                entity.Property(e => e.BmcutW).HasColumnName("bmcut_w");

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CflowId)
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChkDate)
                    .HasColumnName("chk_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CmainId)
                    .HasColumnName("cmain_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintId)
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");

                entity.Property(e => e.Lbom).HasColumnName("lbom");

                entity.Property(e => e.Lcheck).HasColumnName("lcheck");

                entity.Property(e => e.Lplant).HasColumnName("lplant");

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.EngPicWareH)
                    .WithMany(p => p.MemberWareH)
                    .HasForeignKey(d => new { d.CengId, d.CmemPic, d.VerName })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Member_WareH_EngPic_WareH");
            });

            modelBuilder.Entity<ModifyLog>(entity =>
            {
                entity.HasKey(e => e.IOrder);

                entity.ToTable("Modify_Log");

                entity.Property(e => e.IOrder).HasColumnName("iOrder");

                entity.Property(e => e.CFieldName)
                    .HasColumnName("cFieldName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CMode)
                    .HasColumnName("cMode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CNewValue)
                    .HasColumnName("cNewValue")
                    .HasMaxLength(200);

                entity.Property(e => e.COldValue)
                    .HasColumnName("cOldValue")
                    .HasMaxLength(200);

                entity.Property(e => e.CPk)
                    .HasColumnName("cPK")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CTableName)
                    .HasColumnName("cTableName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtEng>(entity =>
            {
                entity.HasKey(e => e.Wheng);

                entity.ToTable("Mt_Eng");

                entity.Property(e => e.Wheng)
                    .HasColumnName("WHEng")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CSort)
                    .HasColumnName("cSort")
                    .HasMaxLength(6);

                entity.Property(e => e.MtClose)
                    .IsRequired()
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.WhengName)
                    .HasColumnName("WHEng_Name")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<MtExtraD>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.Item, e.Whno })
                    .HasName("PK_Mt_ExtraD_1");

                entity.ToTable("Mt_ExtraD");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Whno)
                    .HasColumnName("WHNo")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.BelongSoc)
                    .HasColumnName("Belong_Soc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MtNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.StockPk)
                    .IsRequired()
                    .HasColumnName("StockPK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TierSoc)
                    .HasColumnName("Tier_Soc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Wet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.WhengSoc)
                    .HasColumnName("WHEng_Soc")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.HasOne(d => d.MtExtraT)
                    .WithMany(p => p.MtExtraD)
                    .HasForeignKey(d => new { d.RepId, d.Whno })
                    .HasConstraintName("FK_Mt_ExtraD_Mt_ExtraT");
            });

            modelBuilder.Entity<MtExtraT>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.Whno });

                entity.ToTable("Mt_ExtraT");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Whno)
                    .HasColumnName("WHNo")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.ActNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Belong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.ComMf)
                    .HasColumnName("ComMF")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StkDate).HasColumnType("datetime");

                entity.Property(e => e.StkEmpId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Tier)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WhengExt)
                    .HasColumnName("WHEng_Ext")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtMaterial>(entity =>
            {
                entity.HasKey(e => e.MtNo);

                entity.ToTable("Mt_Material");

                entity.Property(e => e.MtNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.Cdescrip)
                    .HasColumnName("cdescrip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComsupId)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MtType).HasMaxLength(10);

                entity.Property(e => e.Spec)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.Wet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.WetUid)
                    .HasColumnName("WetUId")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtOverTimeBlast>(entity =>
            {
                entity.HasKey(e => new { e.FYear, e.FMonth, e.Plrh, e.Eng });

                entity.ToTable("Mt_OverTimeBLast");

                entity.Property(e => e.FYear)
                    .HasColumnName("fYear")
                    .HasMaxLength(4);

                entity.Property(e => e.FMonth)
                    .HasColumnName("fMonth")
                    .HasMaxLength(2);

                entity.Property(e => e.Plrh)
                    .HasColumnName("plrh")
                    .HasMaxLength(2);

                entity.Property(e => e.Eng).HasMaxLength(7);

                entity.Property(e => e.Ae5001)
                    .HasColumnName("AE5001")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5002)
                    .HasColumnName("AE5002")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5003)
                    .HasColumnName("AE5003")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5004)
                    .HasColumnName("AE5004")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5005)
                    .HasColumnName("AE5005")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5006)
                    .HasColumnName("AE5006")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5007)
                    .HasColumnName("AE5007")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5008)
                    .HasColumnName("AE5008")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5009)
                    .HasColumnName("AE5009")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5010)
                    .HasColumnName("AE5010")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5011)
                    .HasColumnName("AE5011")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5201)
                    .HasColumnName("AE5201")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5202)
                    .HasColumnName("AE5202")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5203)
                    .HasColumnName("AE5203")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5204)
                    .HasColumnName("AE5204")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5205)
                    .HasColumnName("AE5205")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5206)
                    .HasColumnName("AE5206")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5207)
                    .HasColumnName("AE5207")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5208)
                    .HasColumnName("AE5208")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5209)
                    .HasColumnName("AE5209")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5210)
                    .HasColumnName("AE5210")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Ae5211)
                    .HasColumnName("AE5211")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.Dtype)
                    .HasColumnName("DType")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<MtPurchD>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.IItem });

                entity.ToTable("Mt_PurchD");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.IItem).HasColumnName("iItem");

                entity.Property(e => e.ContNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Dlvdt)
                    .HasColumnName("DLVDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.MtLen).HasColumnName("Mt_Len");

                entity.Property(e => e.MtNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.MtWet)
                    .HasColumnName("Mt_Wet")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.MtWide).HasColumnName("Mt_Wide");

                entity.Property(e => e.WetUid)
                    .HasColumnName("WetUId")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.MtPurchD)
                    .HasForeignKey(d => d.RepId)
                    .HasConstraintName("FK_Mt_PurchD_Mt_PurchT");
            });

            modelBuilder.Entity<MtPurchT>(entity =>
            {
                entity.HasKey(e => e.RepId);

                entity.ToTable("Mt_PurchT");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Belong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Ddate)
                    .HasColumnName("DDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dlvdp)
                    .HasColumnName("DLVDP")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Dlvdt)
                    .HasColumnName("DLVDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Enoin)
                    .HasColumnName("ENOIN")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Etpco)
                    .HasColumnName("ETPCO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pdate)
                    .HasColumnName("PDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tier)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtRecvD>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.Whno, e.Item, e.Qty, e.Wet })
                    .HasName("PK_Mt_RecvD_1");

                entity.ToTable("Mt_RecvD");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Whno)
                    .HasColumnName("WHNo")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Wet)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Belong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MtLen).HasColumnName("Mt_Len");

                entity.Property(e => e.MtNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.MtWidth).HasColumnName("Mt_Width");

                entity.Property(e => e.PurRepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.PurUnit)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StockNo)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StockPk)
                    .HasColumnName("StockPK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tier)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MtRecvT)
                    .WithMany(p => p.MtRecvD)
                    .HasForeignKey(d => new { d.RepId, d.Whno })
                    .HasConstraintName("FK_Mt_RecvD_Mt_RecvT1");
            });

            modelBuilder.Entity<MtRecvT>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.Whno });

                entity.ToTable("Mt_RecvT");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Whno)
                    .HasColumnName("WHNo")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.ActNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.ComMf)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RecDate).HasColumnType("datetime");

                entity.Property(e => e.StkDate).HasColumnType("datetime");

                entity.Property(e => e.StkEmpId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Wheng)
                    .IsRequired()
                    .HasColumnName("WHEng")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtRejD>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.StockNo });

                entity.ToTable("Mt_RejD");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.StockNo)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.MtRejD)
                    .HasForeignKey(d => d.RepId)
                    .HasConstraintName("FK_Mt_RejD_Mt_RejT");
            });

            modelBuilder.Entity<MtRejT>(entity =>
            {
                entity.HasKey(e => e.RepId)
                    .HasName("PK_Mt_RejTitle_1");

                entity.ToTable("Mt_RejT");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.ActNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.ChkEmpId)
                    .HasColumnName("chkEmpId")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RepIdRecv)
                    .HasColumnName("RepId_Recv")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.StkDate).HasColumnType("datetime");

                entity.Property(e => e.StkEmpId)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtReturnD>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.Item, e.WhnoI });

                entity.ToTable("Mt_ReturnD");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.WhnoI)
                    .HasColumnName("WHNo_I")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.BelongI)
                    .HasColumnName("Belong_I")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BelongSoc)
                    .HasColumnName("Belong_Soc")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ireturn).HasColumnName("IReturn");

                entity.Property(e => e.MtLen).HasColumnName("Mt_Len");

                entity.Property(e => e.MtNo)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.MtWidth).HasColumnName("Mt_Width");

                entity.Property(e => e.StockNo)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StockPk)
                    .HasColumnName("StockPK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TierI)
                    .HasColumnName("Tier_I")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TierSoc)
                    .HasColumnName("Tier_Soc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Wet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.WhengI)
                    .HasColumnName("WHEng_I")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.WhengSoc)
                    .HasColumnName("WHEng_Soc")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.HasOne(d => d.MtNoNavigation)
                    .WithMany(p => p.MtReturnD)
                    .HasForeignKey(d => d.MtNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mt_ReturnD_Mt_Material");

                entity.HasOne(d => d.MtReturnT)
                    .WithMany(p => p.MtReturnD)
                    .HasForeignKey(d => new { d.RepId, d.WhnoI })
                    .HasConstraintName("FK_Mt_ReturnD_Mt_ReturnT1");
            });

            modelBuilder.Entity<MtReturnT>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.WhnoI });

                entity.ToTable("Mt_ReturnT");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.WhnoI)
                    .HasColumnName("WHNo_I")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.ActNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.ComMf)
                    .HasColumnName("ComMF")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Rdate)
                    .HasColumnName("RDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StkDate).HasColumnType("datetime");

                entity.Property(e => e.StkEmpId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtStockD>(entity =>
            {
                entity.HasKey(e => new { e.StockPk, e.Wheng, e.Tier, e.Belong, e.Slocate })
                    .HasName("PK_Mt_StockD_1");

                entity.ToTable("Mt_StockD");

                entity.Property(e => e.StockPk)
                    .HasColumnName("StockPK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wheng)
                    .HasColumnName("WHEng")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Tier)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Belong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Slocate)
                    .HasColumnName("SLocate")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.StockPkNavigation)
                    .WithMany(p => p.MtStockD)
                    .HasForeignKey(d => d.StockPk)
                    .HasConstraintName("FK_Mt_StockD_Mt_StockT");

                entity.HasOne(d => d.WhengNavigation)
                    .WithMany(p => p.MtStockD)
                    .HasForeignKey(d => d.Wheng)
                    .HasConstraintName("FK_Mt_StockD_Mt_Eng");
            });

            modelBuilder.Entity<MtStockDbk>(entity =>
            {
                entity.HasKey(e => new { e.StockPk, e.Wheng, e.Tier, e.Belong, e.Bkno })
                    .HasName("PK_Mt_StockDBK_1");

                entity.ToTable("Mt_StockDBK");

                entity.Property(e => e.StockPk)
                    .HasColumnName("StockPK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wheng)
                    .HasColumnName("WHEng")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Tier)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Belong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bkno).HasColumnName("BKNo");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MtStockTbk)
                    .WithMany(p => p.MtStockDbk)
                    .HasForeignKey(d => new { d.StockPk, d.Bkno })
                    .HasConstraintName("FK_Mt_StockDBK_Mt_StockTBK1");
            });

            modelBuilder.Entity<MtStockLog>(entity =>
            {
                entity.HasKey(e => e.LogPk);

                entity.ToTable("Mt_StockLog");

                entity.Property(e => e.LogPk).HasColumnName("LogPK");

                entity.Property(e => e.ActNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.QtyDec).HasColumnName("Qty_dec");

                entity.Property(e => e.QtyInc).HasColumnName("Qty_inc");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.StockPk)
                    .HasColumnName("StockPK")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Wheng)
                    .HasColumnName("WHEng")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtStockT>(entity =>
            {
                entity.HasKey(e => e.StockPk);

                entity.ToTable("Mt_StockT");

                entity.Property(e => e.StockPk)
                    .HasColumnName("StockPK")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Belong)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.MtLen).HasColumnName("Mt_Len");

                entity.Property(e => e.MtNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.MtType).HasColumnName("Mt_Type");

                entity.Property(e => e.MtWidth).HasColumnName("Mt_Width");

                entity.Property(e => e.StDate).HasColumnType("datetime");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Tier)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.Wet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.WhengFst)
                    .HasColumnName("WHEng_Fst")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.WhengRtn)
                    .HasColumnName("WHEng_Rtn")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Whno)
                    .IsRequired()
                    .HasColumnName("WHNo")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");
            });

            modelBuilder.Entity<MtStockTbk>(entity =>
            {
                entity.HasKey(e => new { e.StockPk, e.Bkno });

                entity.ToTable("Mt_StockTBK");

                entity.Property(e => e.StockPk)
                    .HasColumnName("StockPK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bkno).HasColumnName("BKNo");

                entity.Property(e => e.AdjDate).HasColumnType("datetime");

                entity.Property(e => e.Belong)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.MtLen).HasColumnName("Mt_Len");

                entity.Property(e => e.MtNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.MtType).HasColumnName("Mt_Type");

                entity.Property(e => e.MtWidth).HasColumnName("Mt_Width");

                entity.Property(e => e.StDate).HasColumnType("datetime");

                entity.Property(e => e.StockNo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Tier)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.Wet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.WhengFst)
                    .HasColumnName("WHEng_Fst")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.WhengRtn)
                    .HasColumnName("WHEng_Rtn")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Whno)
                    .IsRequired()
                    .HasColumnName("WHNo")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");
            });

            modelBuilder.Entity<MtTransD>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.Whno, e.StockPk, e.ActNo, e.Item })
                    .HasName("PK_Mt_TransD_1");

                entity.ToTable("Mt_TransD");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Whno)
                    .HasColumnName("WHNo")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.StockPk)
                    .HasColumnName("StockPK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Belong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MtNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Tier)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Wet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Wheng)
                    .HasColumnName("WHEng")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.HasOne(d => d.MtTransT)
                    .WithMany(p => p.MtTransD)
                    .HasForeignKey(d => new { d.RepId, d.Whno })
                    .HasConstraintName("FK_Mt_TransD_Mt_TransT");
            });

            modelBuilder.Entity<MtTransT>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.Whno })
                    .HasName("PK_Mt_TransTitle");

                entity.ToTable("Mt_TransT");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Whno)
                    .HasColumnName("WHNo")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.StkDate).HasColumnType("datetime");

                entity.Property(e => e.StkEmpId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Unit)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NcrBom>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CmemId })
                    .HasName("PK_NcrBom_N");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongId)
                    .IsRequired()
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .IsRequired()
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");

                entity.HasOne(d => d.NcrTitle)
                    .WithMany(p => p.NcrBom)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_NcrBom_NcrTitle");
            });

            modelBuilder.Entity<NcrDuty>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CDepId, e.CsupId })
                    .HasName("PK_NcrDuty_N");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Bproportion)
                    .HasColumnName("bproportion")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Lagree).HasColumnName("lagree");

                entity.Property(e => e.Nwastage)
                    .HasColumnName("nwastage")
                    .HasColumnType("decimal(10, 1)");

                entity.HasOne(d => d.NcrTitle)
                    .WithMany(p => p.NcrDuty)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_NcrDuty_NcrTitle");
            });

            modelBuilder.Entity<NcrFailWorkRptDetail>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CengId, e.RepId });

                entity.Property(e => e.Id).HasMaxLength(10);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId).HasMaxLength(20);

                entity.Property(e => e.Cfailwork)
                    .HasColumnName("cfailwork")
                    .HasMaxLength(1000);

                entity.Property(e => e.Cnote)
                    .HasColumnName("cnote")
                    .HasMaxLength(200);

                entity.Property(e => e.H1).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.H2).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.H3).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.H4).HasColumnType("decimal(9, 3)");

                entity.HasOne(d => d.NcrFailWorkRptTitle)
                    .WithMany(p => p.NcrFailWorkRptDetail)
                    .HasForeignKey(d => new { d.Id, d.CengId })
                    .HasConstraintName("FK_NcrFailWorkRptDetail_NcrFailWorkRptTitle");
            });

            modelBuilder.Entity<NcrFailWorkRptTitle>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CengId });

                entity.Property(e => e.Id).HasMaxLength(10);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cnote)
                    .HasColumnName("cnote")
                    .HasMaxLength(300);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<NcrFault>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.Ifault })
                    .HasName("PK_NcrFault_N");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ifault).HasColumnName("ifault");

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");

                entity.HasOne(d => d.IfaultNavigation)
                    .WithMany(p => p.NcrFault)
                    .HasForeignKey(d => d.Ifault)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NcrFault_NcrFaultName");

                entity.HasOne(d => d.NcrTitle)
                    .WithMany(p => p.NcrFault)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_NcrFault_NcrTitle");
            });

            modelBuilder.Entity<NcrFaultName>(entity =>
            {
                entity.HasKey(e => e.Ifault);

                entity.Property(e => e.Ifault)
                    .HasColumnName("ifault")
                    .ValueGeneratedNever();

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(20)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");
            });

            modelBuilder.Entity<NcrFeedBack>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CDepId, e.IWorkStation })
                    .HasName("PK_NcrFeedBack_N");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.IWorkStation).HasColumnName("iWorkStation");

                entity.Property(e => e.Nwastage)
                    .HasColumnName("nwastage")
                    .HasColumnType("decimal(10, 1)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.NworkH)
                    .HasColumnName("nwork_h")
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.HasOne(d => d.IWorkStationNavigation)
                    .WithMany(p => p.NcrFeedBack)
                    .HasForeignKey(d => d.IWorkStation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NcrFeedBack_NcrWorkStation");

                entity.HasOne(d => d.NcrTitle)
                    .WithMany(p => p.NcrFeedBack)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_NcrFeedBack_NcrTitle");
            });

            modelBuilder.Entity<NcrImprov>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CDepId })
                    .HasName("PK_NcrImprov_N");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cimprov)
                    .HasColumnName("cimprov")
                    .HasMaxLength(800);

                entity.Property(e => e.Ddist)
                    .HasColumnName("ddist")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lappendix)
                    .HasColumnName("lappendix")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.NcrTitle)
                    .WithMany(p => p.NcrImprov)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_NcrImprov_NcrTitle");
            });

            modelBuilder.Entity<NcrIssueUnit>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CDepId })
                    .HasName("PK_NcrIssueUnit_N");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cdisp)
                    .HasColumnName("cdisp")
                    .HasMaxLength(800);

                entity.Property(e => e.Ddist)
                    .HasColumnName("ddist")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lappendix).HasColumnName("lappendix");

                entity.Property(e => e.Lfb).HasColumnName("lfb");

                entity.Property(e => e.Lneedfb).HasColumnName("lneedfb");

                entity.HasOne(d => d.NcrTitle)
                    .WithMany(p => p.NcrIssueUnit)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_NcrIssueUnit_NcrTitle");
            });

            modelBuilder.Entity<NcrProposal>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CDepId })
                    .HasName("PK_NcrProposal_N");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Cproposal)
                    .HasColumnName("cproposal")
                    .HasMaxLength(800);

                entity.HasOne(d => d.NcrTitle)
                    .WithMany(p => p.NcrProposal)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_NcrProposal_NcrTitle");
            });

            modelBuilder.Entity<NcrStatus>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.Stage, e.CDepId, e.SignOrder });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DSign)
                    .HasColumnName("dSign")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.NcrTitle)
                    .WithMany(p => p.NcrStatus)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_NcrStatus_NcrTitle");
            });

            modelBuilder.Entity<NcrStrategy>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CDepId });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Canalysis)
                    .HasColumnName("canalysis")
                    .HasMaxLength(800);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.Cstrategy)
                    .HasColumnName("cstrategy")
                    .HasMaxLength(800);

                entity.Property(e => e.IflowId).HasColumnName("iflow_id");

                entity.Property(e => e.Lappendix).HasColumnName("lappendix");

                entity.HasOne(d => d.NcrTitle)
                    .WithMany(p => p.NcrStrategy)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_NcrStrategy_NcrTitle");
            });

            modelBuilder.Entity<NcrStrategyStatus>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.IflowId, e.CDepId, e.Dconf });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IflowId).HasColumnName("iflow_id");

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Dconf)
                    .HasColumnName("dconf")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.CusrName)
                    .IsRequired()
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NcrDep)
                    .IsRequired()
                    .HasColumnName("ncrDep")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.NcrStrategy)
                    .WithMany(p => p.NcrStrategyStatus)
                    .HasForeignKey(d => new { d.CengId, d.RepId, d.NcrDep })
                    .HasConstraintName("FK_NcrStrategyStatus_NcrStrategy");
            });

            modelBuilder.Entity<NcrTitle>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId })
                    .HasName("PK_NcrTitle_N");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CDepId)
                    .IsRequired()
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Canceldesp)
                    .HasColumnName("canceldesp")
                    .HasMaxLength(800);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.Cdescp)
                    .IsRequired()
                    .HasColumnName("cdescp")
                    .HasMaxLength(800);

                entity.Property(e => e.ChkDate).HasColumnType("datetime");

                entity.Property(e => e.ClsNo)
                    .HasColumnName("cls_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cproposal)
                    .HasColumnName("cproposal")
                    .HasMaxLength(800);

                entity.Property(e => e.Creatname)
                    .IsRequired()
                    .HasColumnName("creatname")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Creplen)
                    .HasColumnName("creplen")
                    .HasMaxLength(800);

                entity.Property(e => e.CusrName)
                    .IsRequired()
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Deadline)
                    .HasColumnName("deadline")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelayNote)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Dfinish)
                    .HasColumnName("dfinish")
                    .HasColumnType("datetime");

                entity.Property(e => e.Distdate)
                    .HasColumnName("distdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IErrType).HasColumnName("iErrType");

                entity.Property(e => e.IflowId).HasColumnName("iflow_id");

                entity.Property(e => e.Isfactory).HasColumnName("isfactory");

                entity.Property(e => e.LDelayClose)
                    .HasColumnName("lDelayClose")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.Property(e => e.Lappendix).HasColumnName("lappendix");

                entity.Property(e => e.Lissue).HasColumnName("lissue");

                entity.Property(e => e.Lprop).HasColumnName("lprop");

                entity.Property(e => e.Lresp).HasColumnName("lresp");

                entity.Property(e => e.Lstrategy).HasColumnName("lstrategy");

                entity.Property(e => e.NactworkH)
                    .HasColumnName("nactwork_h")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NworkH)
                    .HasColumnName("nwork_h")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SaveDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NcrType>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.Itype })
                    .HasName("PK_NcrType_N");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Itype).HasColumnName("itype");

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");

                entity.HasOne(d => d.ItypeNavigation)
                    .WithMany(p => p.NcrType)
                    .HasForeignKey(d => d.Itype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NcrType_NcrTypeName");

                entity.HasOne(d => d.NcrTitle)
                    .WithMany(p => p.NcrType)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_NcrType_NcrTitle");
            });

            modelBuilder.Entity<NcrTypeName>(entity =>
            {
                entity.HasKey(e => e.Itype);

                entity.Property(e => e.Itype)
                    .HasColumnName("itype")
                    .ValueGeneratedNever();

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(20)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Lfault).HasColumnName("lfault");

                entity.Property(e => e.Lfb).HasColumnName("lfb");
            });

            modelBuilder.Entity<NcrWorkStation>(entity =>
            {
                entity.HasKey(e => e.IWorkStation);

                entity.Property(e => e.IWorkStation)
                    .HasColumnName("iWorkStation")
                    .ValueGeneratedNever();

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.IsFactory)
                    .HasColumnName("isFactory")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.HasKey(e => e.COwnerId)
                    .HasName("PK_EngOwner");

                entity.Property(e => e.COwnerId)
                    .HasColumnName("cOwner_id")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CAddress)
                    .HasColumnName("cAddress")
                    .HasMaxLength(100);

                entity.Property(e => e.CFax)
                    .HasColumnName("cFax")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(40);

                entity.Property(e => e.CTel)
                    .HasColumnName("cTel")
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OwnerEmp>(entity =>
            {
                entity.HasKey(e => new { e.COwnerId, e.Contact })
                    .HasName("PK_EngOwnerEmp");

                entity.Property(e => e.COwnerId)
                    .HasColumnName("cOwner_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(10);

                entity.Property(e => e.CEmail)
                    .HasColumnName("cEmail")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CExt)
                    .HasColumnName("cExt")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CFax)
                    .HasColumnName("cFax")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CNote)
                    .HasColumnName("cNote")
                    .HasMaxLength(40);

                entity.Property(e => e.CTel)
                    .HasColumnName("cTel")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.COwner)
                    .WithMany(p => p.OwnerEmp)
                    .HasForeignKey(d => d.COwnerId)
                    .HasConstraintName("FK_OwnerEmp_Owner");
            });

            modelBuilder.Entity<PaintClass>(entity =>
            {
                entity.HasKey(e => e.CpaintId)
                    .HasName("PK_Paint_Class");

                entity.ToTable("Paint_class");

                entity.Property(e => e.CpaintId)
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CpaintName)
                    .IsRequired()
                    .HasColumnName("cpaint_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PicClass>(entity =>
            {
                entity.HasKey(e => e.CPicClass)
                    .HasName("PK_PicClassified");

                entity.Property(e => e.CPicClass)
                    .HasColumnName("cPicClass")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(16);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LMember).HasColumnName("lMember");
            });

            modelBuilder.Entity<PicRule>(entity =>
            {
                entity.HasKey(e => new { e.CPicClass, e.CPicType });

                entity.Property(e => e.CPicClass)
                    .HasColumnName("cPicClass")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CPicType)
                    .HasColumnName("cPicType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CDescp)
                    .HasColumnName("cDescp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CFixCode)
                    .HasColumnName("cFixCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IFixSite).HasColumnName("iFixSite");

                entity.HasOne(d => d.CPicClassNavigation)
                    .WithMany(p => p.PicRule)
                    .HasForeignKey(d => d.CPicClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PicRule_PicClassified");

                entity.HasOne(d => d.CPicTypeNavigation)
                    .WithMany(p => p.PicRule)
                    .HasForeignKey(d => d.CPicType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PicRule_PicType");
            });

            modelBuilder.Entity<PicType>(entity =>
            {
                entity.HasKey(e => e.CPicType);

                entity.Property(e => e.CPicType)
                    .HasColumnName("cPicType")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(16);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PicVer>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.VerName });

                entity.Property(e => e.CengId)
                    .HasColumnName("Ceng_Id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.VerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate).HasColumnType("datetime");

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Udate).HasColumnType("datetime");

                entity.Property(e => e.VerDesp)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PilotSpDetail>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CmakId });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Bweight)
                    .HasColumnName("bweight")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.CmakDesp)
                    .IsRequired()
                    .HasColumnName("cmak_desp")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Qty).HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.HasOne(d => d.PilotSpTitle)
                    .WithMany(p => p.PilotSpDetail)
                    .HasForeignKey(d => new { d.RepId, d.CengId })
                    .HasConstraintName("FK_PilotSpDetail_PilotSpTitle");
            });

            modelBuilder.Entity<PilotSpTitle>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.CengId })
                    .HasName("PK_sp_data");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CGrantUnit)
                    .HasColumnName("cGrantUnit")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DFb)
                    .HasColumnName("dFb")
                    .HasColumnType("datetime");

                entity.Property(e => e.DRecv)
                    .HasColumnName("dRecv")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descp)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StrSch)
                    .HasColumnName("strSch")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.Cdescrip)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.Cdescrip)
                    .HasColumnName("cdescrip")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Barea).HasColumnName("barea");

                entity.Property(e => e.BsurfaceA).HasColumnName("bsurface_a");

                entity.Property(e => e.BsurfaceB).HasColumnName("bsurface_b");

                entity.Property(e => e.Bweight).HasColumnName("bweight");

                entity.Property(e => e.CclassId)
                    .IsRequired()
                    .HasColumnName("cclass_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdim1)
                    .HasColumnName("cdim1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdim2)
                    .HasColumnName("cdim2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdim3)
                    .HasColumnName("cdim3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdim4)
                    .HasColumnName("cdim4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ledit)
                    .IsRequired()
                    .HasColumnName("ledit")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.HasOne(d => d.Cclass)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.CclassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Profile_Steel_class");
            });

            modelBuilder.Entity<Qa>(entity =>
            {
                entity.HasKey(e => e.RepId);

                entity.ToTable("QA");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.BImper).HasColumnName("bImper");

                entity.Property(e => e.CClose)
                    .HasColumnName("cClose")
                    .HasMaxLength(200);

                entity.Property(e => e.CCreatUser)
                    .HasColumnName("cCreat_User")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CDepId)
                    .IsRequired()
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CRequest)
                    .HasColumnName("cRequest")
                    .HasMaxLength(1000);

                entity.Property(e => e.CTitle)
                    .HasColumnName("cTitle")
                    .HasMaxLength(100);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.CengId)
                    .IsRequired()
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .IsRequired()
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DActAns)
                    .HasColumnName("dActAns")
                    .HasColumnType("datetime");

                entity.Property(e => e.DClose)
                    .HasColumnName("dClose")
                    .HasColumnType("datetime");

                entity.Property(e => e.DExpAns)
                    .HasColumnName("dExpAns")
                    .HasColumnType("datetime");

                entity.Property(e => e.IRating).HasColumnName("iRating");

                entity.Property(e => e.IflowId).HasColumnName("iflow_id");

                entity.Property(e => e.IwfId)
                    .HasColumnName("iwf_id")
                    .HasDefaultValueSql("((4))");
            });

            modelBuilder.Entity<QaFeedback>(entity =>
            {
                entity.HasKey(e => e.DUp);

                entity.ToTable("QA_Feedback");

                entity.Property(e => e.DUp)
                    .HasColumnName("dUp")
                    .HasColumnType("datetime");

                entity.Property(e => e.CFileName)
                    .IsRequired()
                    .HasColumnName("cFileName")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DFeedback)
                    .HasColumnName("dFeedback")
                    .HasColumnType("datetime");

                entity.Property(e => e.RepId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.QaFeedback)
                    .HasForeignKey(d => d.RepId)
                    .HasConstraintName("FK_QA_Feedback_QA1");
            });

            modelBuilder.Entity<QaRece>(entity =>
            {
                entity.HasKey(e => new { e.RepId, e.CownerId, e.Contact });

                entity.ToTable("QA_Rece");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CownerId)
                    .HasColumnName("cowner_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(10);

                entity.Property(e => e.COrig)
                    .IsRequired()
                    .HasColumnName("cOrig")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.QaRece)
                    .HasForeignKey(d => d.RepId)
                    .HasConstraintName("FK_QA_Rece_QA");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.QaRece)
                    .HasForeignKey(d => new { d.CownerId, d.Contact })
                    .HasConstraintName("FK_QA_Rece_OwnerEmp");
            });

            modelBuilder.Entity<QaStatus>(entity =>
            {
                entity.HasKey(e => e.DSign);

                entity.ToTable("QA_Status");

                entity.Property(e => e.DSign)
                    .HasColumnName("dSign")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDepId)
                    .IsRequired()
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CusrName)
                    .IsRequired()
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IflowId).HasColumnName("iflow_id");

                entity.Property(e => e.IwfId)
                    .HasColumnName("iwf_id")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.RepId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rep)
                    .WithMany(p => p.QaStatus)
                    .HasForeignKey(d => d.RepId)
                    .HasConstraintName("FK_QA_Status_QA1");
            });

            modelBuilder.Entity<Qaexp>(entity =>
            {
                entity.HasKey(e => e.RepId)
                    .HasName("PK_QA範例");

                entity.ToTable("QAExp");

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CRequest)
                    .HasColumnName("cRequest")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CTitle)
                    .HasColumnName("cTitle")
                    .HasMaxLength(100)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.IType).HasColumnName("iType");

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.HasOne(d => d.ITypeNavigation)
                    .WithMany(p => p.Qaexp)
                    .HasForeignKey(d => d.IType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QAExp_QAExpType");
            });

            modelBuilder.Entity<QaexpType>(entity =>
            {
                entity.HasKey(e => e.IType);

                entity.ToTable("QAExpType");

                entity.Property(e => e.IType)
                    .HasColumnName("iType")
                    .ValueGeneratedNever();

                entity.Property(e => e.CDescp)
                    .IsRequired()
                    .HasColumnName("cDescp")
                    .HasMaxLength(100)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");
            });

            modelBuilder.Entity<RGrpUserSup>(entity =>
            {
                entity.HasKey(e => new { e.CgrpName, e.CId });

                entity.ToTable("R_GrpUserSup");

                entity.Property(e => e.CgrpName)
                    .HasColumnName("cgrp_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CId)
                    .HasColumnName("cId")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.HasOne(d => d.CgrpNameNavigation)
                    .WithMany(p => p.RGrpUserSup)
                    .HasForeignKey(d => d.CgrpName)
                    .HasConstraintName("FK_R_GrpUserSup_TGroup");
            });

            modelBuilder.Entity<Right>(entity =>
            {
                entity.HasKey(e => e.CRight)
                    .HasName("PK_RightDesc");

                entity.Property(e => e.CRight)
                    .HasColumnName("cRight")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CRightDesc)
                    .HasColumnName("cRightDesc")
                    .HasMaxLength(40);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.IOrder)
                    .HasColumnName("iOrder")
                    .HasDefaultValueSql("((99))");
            });

            modelBuilder.Entity<Rpt>(entity =>
            {
                entity.Property(e => e.RptId)
                    .HasColumnName("rpt_Id")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CfrmName)
                    .HasColumnName("cfrm_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RptDesp)
                    .IsRequired()
                    .HasColumnName("rpt_desp")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RptSort).HasColumnName("rpt_sort");

                entity.Property(e => e.RptType).HasColumnName("rpt_type");

                entity.HasOne(d => d.CfrmNameNavigation)
                    .WithMany(p => p.RptNavigation)
                    .HasForeignKey(d => d.CfrmName)
                    .HasConstraintName("FK__Rpt__cfrm_name__247341CE");
            });

            modelBuilder.Entity<SignFlow>(entity =>
            {
                entity.HasKey(e => new { e.IwfId, e.IflowId });

                entity.Property(e => e.IwfId).HasColumnName("iwf_id");

                entity.Property(e => e.IflowId).HasColumnName("iflow_id");

                entity.Property(e => e.CDepId)
                    .IsRequired()
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CStatusDesp)
                    .HasColumnName("cStatus_desp")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CflowName)
                    .IsRequired()
                    .HasColumnName("cflow_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CwfName)
                    .IsRequired()
                    .HasColumnName("cwf_name")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Iclass).HasColumnName("iclass");
            });

            modelBuilder.Entity<SpFunSta>(entity =>
            {
                entity.HasKey(e => e.FunRptId);

                entity.Property(e => e.CRangeId)
                    .HasColumnName("cRange_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CSiteId)
                    .HasColumnName("cSiteId")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Iqty).HasColumnName("iqty");

                entity.Property(e => e.OrgRangeId)
                    .HasColumnName("org_RangeId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RQty).HasColumnName("rQty");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.SpFunSta)
                    .HasForeignKey(d => new { d.CengId, d.CRangeId })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SpFunSta_SPRangeTitle");
            });

            modelBuilder.Entity<SpLedger>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmakId });

                entity.ToTable("sp_ledger");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeQty)
                    .HasColumnName("arrange_qty")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.DrawQty)
                    .HasColumnName("draw_qty")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.PlantQty).HasColumnName("plant_qty");

                entity.Property(e => e.ProdFeedback)
                    .HasColumnName("prod_feedback")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.RenewQty)
                    .HasColumnName("renew_qty")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.StFeedback)
                    .HasColumnName("st_feedback")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.TuneQty)
                    .HasColumnName("tune_qty")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");
            });

            modelBuilder.Entity<SpfunRpt>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CfunId, e.FunRptId });

                entity.ToTable("SPFunRpt");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CfunId)
                    .HasColumnName("cfun_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActuallyQty)
                    .HasColumnName("actually_qty")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Iqty)
                    .HasColumnName("iqty")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.PlantQty)
                    .HasColumnName("plant_qty")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.HasOne(d => d.FunRpt)
                    .WithMany(p => p.SpfunRpt)
                    .HasForeignKey(d => d.FunRptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPFunRpt_SpFunSta");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.SpfunRpt)
                    .HasForeignKey(d => new { d.CengId, d.CfunId })
                    .HasConstraintName("FK_SPFunRpt_SPFunTitle");
            });

            modelBuilder.Entity<SpfunTitle>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CfunId })
                    .HasName("PK_SpFunTitle");

                entity.ToTable("SPFunTitle");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CfunId)
                    .HasColumnName("cfun_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CGrantUnit)
                    .HasColumnName("cGrantUnit")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CRangeId)
                    .HasColumnName("cRange_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CSiteId)
                    .HasColumnName("cSiteId")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cdescp)
                    .HasColumnName("cdescp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DFb)
                    .HasColumnName("dFb")
                    .HasColumnType("datetime");

                entity.Property(e => e.StrSch)
                    .HasColumnName("strSch")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.C)
                    .WithMany(p => p.SpfunTitle)
                    .HasForeignKey(d => new { d.CengId, d.CRangeId })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SPFunTitle_SPRangeTitle");
            });

            modelBuilder.Entity<SprangeDetail>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CRangeId, e.CmemId, e.CdivName, e.CmakId });

                entity.ToTable("SPRangeDetail");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRangeId)
                    .HasColumnName("cRange_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CmakDesp)
                    .HasColumnName("cmak_desp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Cspec)
                    .HasColumnName("cspec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IQty).HasColumnName("iQty");

                entity.Property(e => e.Nweight)
                    .HasColumnName("nweight")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.SprangeDetail)
                    .HasForeignKey(d => new { d.CengId, d.CRangeId })
                    .HasConstraintName("FK_SPRangeDetail_SPRangeTitle");
            });

            modelBuilder.Entity<SprangeMem>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CRangeId, e.CmemId, e.CdivName });

                entity.ToTable("SPRangeMem");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRangeId)
                    .HasColumnName("cRange_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.C)
                    .WithMany(p => p.SprangeMem)
                    .HasForeignKey(d => new { d.CengId, d.CRangeId })
                    .HasConstraintName("FK_SPRangeMem_SPRangeTitle");
            });

            modelBuilder.Entity<SprangeTitle>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CRangeId })
                    .HasName("PK_sp_rangetitle");

                entity.ToTable("SPRangeTitle");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRangeId)
                    .HasColumnName("cRange_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cdescp)
                    .HasColumnName("cdescp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DRecv)
                    .HasColumnName("dRecv")
                    .HasColumnType("datetime");

                entity.Property(e => e.IQryType).HasColumnName("iQryType");

                entity.Property(e => e.IRangeType).HasColumnName("iRange_type");

                entity.Property(e => e.IRptGrp).HasColumnName("iRptGrp");

                entity.Property(e => e.LRptOk).HasColumnName("lRptOk");
            });

            modelBuilder.Entity<Spsite>(entity =>
            {
                entity.HasKey(e => e.CSiteId)
                    .HasName("PK_SpSite");

                entity.ToTable("SPSite");

                entity.Property(e => e.CSiteId)
                    .HasColumnName("cSiteId")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CDescp)
                    .IsRequired()
                    .HasColumnName("cDescp")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SteelClass>(entity =>
            {
                entity.HasKey(e => e.CclassId)
                    .HasName("PK_Steel_Class");

                entity.ToTable("Steel_class");

                entity.HasIndex(e => e.CclassCname)
                    .HasName("steel_class_cclass_cna")
                    .IsUnique();

                entity.Property(e => e.CclassId)
                    .HasColumnName("cclass_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CMakCat)
                    .HasColumnName("cMakCat")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasColumnName("cName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CPicPath)
                    .HasColumnName("cPicPath")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CclassCname)
                    .IsRequired()
                    .HasColumnName("cclass_cname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Cseries)
                    .IsRequired()
                    .HasColumnName("cseries")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NDisplay).HasColumnName("nDisplay");

                entity.Property(e => e.NclassSort).HasColumnName("nclass_sort");

                entity.Property(e => e.NdimNum).HasColumnName("ndim_num");
            });

            modelBuilder.Entity<StsEng>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.Db });

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Db)
                    .HasColumnName("DB")
                    .HasMaxLength(10);

                entity.Property(e => e.CSort)
                    .HasColumnName("cSort")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CengName)
                    .HasColumnName("ceng_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CengSna)
                    .HasColumnName("ceng_sna")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Dclose)
                    .HasColumnName("dclose")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.CsubjectId);

                entity.ToTable("subject");

                entity.Property(e => e.CsubjectId)
                    .HasColumnName("csubject_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CsubjectName)
                    .IsRequired()
                    .HasColumnName("csubject_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CsubjectSort).HasColumnName("csubject_sort");
            });

            modelBuilder.Entity<TBom>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.IbomQty, e.CmakId });

                entity.ToTable("T_Bom");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IbomQty).HasColumnName("ibom_qty");

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BcutA1).HasColumnName("bcut_a1");

                entity.Property(e => e.BcutA2).HasColumnName("bcut_a2");

                entity.Property(e => e.BsurfaceA).HasColumnName("bsurface_a");

                entity.Property(e => e.BsurfaceB).HasColumnName("bsurface_b");

                entity.Property(e => e.Bweight).HasColumnName("bweight");

                entity.Property(e => e.CSiteId)
                    .HasColumnName("cSiteId")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cdescrip)
                    .HasColumnName("cdescrip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CmainId)
                    .HasColumnName("cmain_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmakDesp)
                    .HasColumnName("cmak_desp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintId)
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cspec)
                    .HasColumnName("cspec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CuseId)
                    .HasColumnName("cuse_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Lbend).HasColumnName("lbend");

                entity.Property(e => e.Lcal1).HasColumnName("lcal1");

                entity.Property(e => e.Lcal2).HasColumnName("lcal2");

                entity.Property(e => e.Lcut).HasColumnName("lcut");

                entity.Property(e => e.Ledit).HasColumnName("ledit");

                entity.Property(e => e.Lhole).HasColumnName("lhole");

                entity.Property(e => e.Linternal).HasColumnName("linternal");

                entity.Property(e => e.Lmodify).HasColumnName("lmodify");

                entity.Property(e => e.Lnc).HasColumnName("lnc");

                entity.Property(e => e.Lprint).HasColumnName("lprint");

                entity.Property(e => e.Lregular).HasColumnName("lregular");

                entity.Property(e => e.Lsketch).HasColumnName("lsketch");

                entity.Property(e => e.Ltemplate).HasColumnName("ltemplate");

                entity.Property(e => e.Lweld).HasColumnName("lweld");

                entity.Property(e => e.NcutW)
                    .HasColumnName("ncut_w")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.NmakLen)
                    .HasColumnName("nmak_len")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.NmakWidth)
                    .HasColumnName("nmakWidth")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Nweight)
                    .HasColumnName("nweight")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Udate)
                    .HasColumnName("udate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TBomOutExcel>(entity =>
            {
                entity.HasKey(e => new { e.Num, e.CengId, e.CtierName, e.CbelongId, e.CdivName, e.CList4 })
                    .HasName("PK__TempBomOutExcel");

                entity.ToTable("T_BomOutExcel");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(8);

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(8);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(8);

                entity.Property(e => e.CList4)
                    .HasColumnName("cList4")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TChkComsupWork>(entity =>
            {
                entity.HasKey(e => new { e.Num, e.CengId, e.CmemId, e.CdivName, e.CworkId })
                    .HasName("PK__ChkComsupWork");

                entity.ToTable("T_ChkComsupWork");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CworkId)
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CflowId)
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");

                entity.Property(e => e.Message).HasMaxLength(100);

                entity.Property(e => e.Ok).HasColumnName("OK");

                entity.Property(e => e.SurplusQty)
                    .HasColumnName("surplus_qty")
                    .HasColumnType("decimal(9, 4)");

                entity.Property(e => e.UseQty)
                    .HasColumnName("use_qty")
                    .HasColumnType("decimal(9, 4)");
            });

            modelBuilder.Entity<TChkFbsaveData>(entity =>
            {
                entity.HasKey(e => new { e.Rnum, e.Num, e.Message })
                    .HasName("PK__ChkFeedBackSaveData");

                entity.ToTable("T_ChkFBSaveData");

                entity.Property(e => e.Message).HasMaxLength(100);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(10);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Flow).HasColumnName("flow");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(9, 4)");
            });

            modelBuilder.Entity<TChkMsg>(entity =>
            {
                entity.HasKey(e => new { e.Qrykey, e.Strmsg });

                entity.ToTable("T_ChkMsg");

                entity.Property(e => e.Qrykey)
                    .HasColumnName("qrykey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Strmsg)
                    .HasColumnName("strmsg")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Imark).HasColumnName("imark");
            });

            modelBuilder.Entity<TEngPic>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemPic, e.Qrykey })
                    .HasName("PK__EngPic");

                entity.ToTable("T_EngPic");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Qrykey)
                    .HasColumnName("qrykey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RpgName)
                    .HasColumnName("rpg_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TFbFormDg>(entity =>
            {
                entity.HasKey(e => new { e.CmemId, e.CengId });

                entity.ToTable("T_fbFormDG");

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BackQty).HasColumnName("Back_qty");

                entity.Property(e => e.Bsa1).HasColumnName("bsa1");

                entity.Property(e => e.Bsa2).HasColumnName("bsa2");

                entity.Property(e => e.CanBackQty).HasColumnName("CanBack_qty");

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .IsRequired()
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IQty).HasColumnName("i_qty");

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");

                entity.Property(e => e.Iorder).HasColumnName("iorder");

                entity.Property(e => e.ProDate)
                    .HasColumnName("pro_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wet).HasColumnType("decimal(9, 1)");
            });

            modelBuilder.Entity<TFeedBackSave>(entity =>
            {
                entity.HasKey(e => new { e.Rnum, e.Num })
                    .HasName("PK__TempFeedBackSave");

                entity.ToTable("T_FeedBackSave");

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IsBf).HasColumnName("IsBF");

                entity.Property(e => e.Lbom).HasColumnName("lbom");

                entity.Property(e => e.Lcheck).HasColumnName("lcheck");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(9, 4)");

                entity.Property(e => e.Wet).HasColumnType("decimal(9, 1)");
            });

            modelBuilder.Entity<TFunNonBud>(entity =>
            {
                entity.HasKey(e => e.Funrptid);

                entity.ToTable("T_FunNonBud");

                entity.Property(e => e.Funrptid)
                    .HasColumnName("funrptid")
                    .ValueGeneratedNever();

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CmakDesp)
                    .HasColumnName("cmak_desp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Dim1)
                    .HasColumnName("dim1")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Dim2)
                    .HasColumnName("dim2")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Dim3)
                    .HasColumnName("dim3")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Iqty).HasColumnName("iqty");

                entity.Property(e => e.OrgRangeid)
                    .HasColumnName("org_rangeid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rqty).HasColumnName("rqty");

                entity.Property(e => e.Strtype)
                    .HasColumnName("strtype")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TGetFormData>(entity =>
            {
                entity.ToTable("T_GetFormData");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cno)
                    .IsRequired()
                    .HasColumnName("cno")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ViewName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TImpBomFrmWbBom>(entity =>
            {
                entity.HasKey(e => new { e.Qrykey, e.CengId, e.Repid, e.CmemPic });

                entity.ToTable("T_ImpBomFrmWbBom");

                entity.Property(e => e.Qrykey)
                    .HasColumnName("qrykey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Repid)
                    .HasColumnName("repid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");
            });

            modelBuilder.Entity<TImpDiv>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CmemId, e.CdivName, e.Qrykey })
                    .HasName("PK_ImpDiv")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("T_ImpDiv");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Qrykey)
                    .HasColumnName("qrykey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cfied0700)
                    .HasColumnName("cfied_0700")
                    .HasMaxLength(4);

                entity.Property(e => e.Cfied0800)
                    .HasColumnName("cfied_0800")
                    .HasMaxLength(4);

                entity.Property(e => e.Cfied1000)
                    .HasColumnName("cfied_1000")
                    .HasMaxLength(4);

                entity.Property(e => e.Csup0700)
                    .HasColumnName("csup_0700")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Csup0800)
                    .HasColumnName("csup_0800")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Csup1000)
                    .HasColumnName("csup_1000")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.GoalDate)
                    .HasColumnName("goal_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ILine).HasColumnName("iLine");

                entity.Property(e => e.IdivQty).HasColumnName("idiv_qty");
            });

            modelBuilder.Entity<TImpMaking>(entity =>
            {
                entity.HasKey(e => new { e.Qrykey, e.CengId, e.CmakId })
                    .HasName("PK_ImpMaking");

                entity.ToTable("T_ImpMaking");

                entity.Property(e => e.Qrykey)
                    .HasColumnName("qrykey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BcutA1).HasColumnName("bcut_a1");

                entity.Property(e => e.BcutA2).HasColumnName("bcut_a2");

                entity.Property(e => e.CSiteId)
                    .HasColumnName("cSiteId")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CmainId)
                    .HasColumnName("cmain_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmakDesp)
                    .HasColumnName("cmak_desp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintId)
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CuseId)
                    .HasColumnName("cuse_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ILine).HasColumnName("iLine");

                entity.Property(e => e.Lbend).HasColumnName("lbend");

                entity.Property(e => e.Lcal1).HasColumnName("lcal1");

                entity.Property(e => e.Lcal2).HasColumnName("lcal2");

                entity.Property(e => e.Lcut).HasColumnName("lcut");

                entity.Property(e => e.Ledit).HasColumnName("ledit");

                entity.Property(e => e.Lhole).HasColumnName("lhole");

                entity.Property(e => e.Linternal).HasColumnName("linternal");

                entity.Property(e => e.Lmodify).HasColumnName("lmodify");

                entity.Property(e => e.Lnc).HasColumnName("lnc");

                entity.Property(e => e.Lpic)
                    .HasColumnName("lpic")
                    .HasMaxLength(2);

                entity.Property(e => e.Lprint).HasColumnName("lprint");

                entity.Property(e => e.Lregular).HasColumnName("lregular");

                entity.Property(e => e.Lsketch).HasColumnName("lsketch");

                entity.Property(e => e.Ltemplate).HasColumnName("ltemplate");

                entity.Property(e => e.Lweld).HasColumnName("lweld");

                entity.Property(e => e.NcutW)
                    .HasColumnName("ncut_w")
                    .HasColumnType("decimal(9, 1)");
            });

            modelBuilder.Entity<TImpMember>(entity =>
            {
                entity.HasKey(e => new { e.Qrykey, e.CengId, e.CmemId })
                    .HasName("PK_ImpMember");

                entity.ToTable("T_ImpMember");

                entity.Property(e => e.Qrykey)
                    .HasColumnName("qrykey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BmcutA1).HasColumnName("bmcut_a1");

                entity.Property(e => e.BmcutA2).HasColumnName("bmcut_a2");

                entity.Property(e => e.BmcutW).HasColumnName("bmcut_w");

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CflowId)
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintId)
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dssnote)
                    .HasColumnName("dssnote")
                    .HasMaxLength(40);

                entity.Property(e => e.ILine).HasColumnName("iLine");

                entity.Property(e => e.Pcsnote)
                    .HasColumnName("pcsnote")
                    .HasMaxLength(40);

                entity.Property(e => e.Qsanote)
                    .HasColumnName("qsanote")
                    .HasMaxLength(40);

                entity.Property(e => e.Stsnote)
                    .HasColumnName("stsnote")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TImportComSup>(entity =>
            {
                entity.HasKey(e => new { e.WorsId, e.Num });

                entity.ToTable("T_ImportComSup");

                entity.Property(e => e.WorsId).HasColumnName("WorsID");

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Cfied0700Sna)
                    .HasColumnName("cfied0700_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cfied0800Sna)
                    .HasColumnName("cfied0800_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cfied1000Sna)
                    .HasColumnName("cfied1000_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintSna)
                    .HasColumnName("cpaint_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Csup0700Sna)
                    .HasColumnName("csup0700_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Csup0800Sna)
                    .HasColumnName("csup0800_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Csup1000Sna)
                    .HasColumnName("csup1000_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DRender)
                    .HasColumnName("dRender")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TImportFb>(entity =>
            {
                entity.HasKey(e => new { e.Qrykey, e.CengId, e.CmemId, e.IOrder });

                entity.ToTable("T_ImportFB");

                entity.Property(e => e.Qrykey)
                    .HasColumnName("qrykey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IOrder).HasColumnName("iOrder");

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CworkId)
                    .IsRequired()
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");
            });

            modelBuilder.Entity<TMemCut>(entity =>
            {
                entity.HasKey(e => new { e.CtierName, e.CbelongId, e.CmemId, e.CdivName });

                entity.ToTable("T_MemCut");

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BcutA1).HasColumnName("bcut_a1");

                entity.Property(e => e.BcutA2).HasColumnName("bcut_a2");

                entity.Property(e => e.BmcutA1).HasColumnName("bmcut_a1");

                entity.Property(e => e.BmcutA2).HasColumnName("bmcut_a2");

                entity.Property(e => e.BmcutW).HasColumnName("bmcut_w");

                entity.Property(e => e.Bmsurface1).HasColumnName("bmsurface1");

                entity.Property(e => e.Bmsurface2).HasColumnName("bmsurface2");

                entity.Property(e => e.CSpec)
                    .HasColumnName("c_spec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .IsRequired()
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Memwet)
                    .HasColumnName("memwet")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.NcutW).HasColumnName("ncut_w");

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<TMemProc1>(entity =>
            {
                entity.HasKey(e => new { e.Randvalue, e.Num });

                entity.ToTable("T_MemProc1");

                entity.Property(e => e.Randvalue).HasColumnName("randvalue");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.CSpec)
                    .HasColumnName("c_spec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CfiedSna)
                    .HasColumnName("cfied_sna")
                    .HasMaxLength(8);

                entity.Property(e => e.CflowId)
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Cnote)
                    .HasColumnName("cnote")
                    .HasMaxLength(40);

                entity.Property(e => e.CpaintId)
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CsupSna)
                    .HasColumnName("csup_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0001)
                    .HasColumnName("d0001")
                    .HasMaxLength(16);

                entity.Property(e => e.D0100)
                    .HasColumnName("d0100")
                    .HasMaxLength(16);

                entity.Property(e => e.D0500)
                    .HasColumnName("d0500")
                    .HasMaxLength(16);

                entity.Property(e => e.D0600)
                    .HasColumnName("d0600")
                    .HasMaxLength(16);

                entity.Property(e => e.D0601)
                    .HasColumnName("d0601")
                    .HasMaxLength(16);

                entity.Property(e => e.D0602)
                    .HasColumnName("d0602")
                    .HasMaxLength(16);

                entity.Property(e => e.D0603)
                    .HasColumnName("d0603")
                    .HasMaxLength(16);

                entity.Property(e => e.D0604)
                    .HasColumnName("d0604")
                    .HasMaxLength(16);

                entity.Property(e => e.D0700)
                    .HasColumnName("d0700")
                    .HasMaxLength(10);

                entity.Property(e => e.D0800)
                    .HasColumnName("d0800")
                    .HasMaxLength(10);

                entity.Property(e => e.D0900)
                    .HasColumnName("d0900")
                    .HasMaxLength(10);

                entity.Property(e => e.D1000)
                    .HasColumnName("d1000")
                    .HasMaxLength(10);

                entity.Property(e => e.D1100)
                    .HasColumnName("d1100")
                    .HasMaxLength(10);

                entity.Property(e => e.D1200)
                    .HasColumnName("d1200")
                    .HasMaxLength(10);

                entity.Property(e => e.D1300)
                    .HasColumnName("d1300")
                    .HasMaxLength(10);

                entity.Property(e => e.D1400)
                    .HasColumnName("d1400")
                    .HasMaxLength(10);

                entity.Property(e => e.GoalDate)
                    .HasColumnName("goal_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Netsurface1).HasColumnName("netsurface1");

                entity.Property(e => e.Netsurface2).HasColumnName("netsurface2");

                entity.Property(e => e.Netwet)
                    .HasColumnName("netwet")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Picwet)
                    .HasColumnName("picwet")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Q0001).HasColumnName("q0001");

                entity.Property(e => e.Q0100).HasColumnName("q0100");

                entity.Property(e => e.Q0500).HasColumnName("q0500");

                entity.Property(e => e.Q0600).HasColumnName("q0600");

                entity.Property(e => e.Q0601).HasColumnName("q0601");

                entity.Property(e => e.Q0602).HasColumnName("q0602");

                entity.Property(e => e.Q0603).HasColumnName("q0603");

                entity.Property(e => e.Q0604).HasColumnName("q0604");

                entity.Property(e => e.Q0700).HasColumnName("q0700");

                entity.Property(e => e.Q0800).HasColumnName("q0800");

                entity.Property(e => e.Q0900).HasColumnName("q0900");

                entity.Property(e => e.Q1000).HasColumnName("q1000");

                entity.Property(e => e.Q1100).HasColumnName("q1100");

                entity.Property(e => e.Q1200).HasColumnName("q1200");

                entity.Property(e => e.Q1300).HasColumnName("q1300");

                entity.Property(e => e.Q1400).HasColumnName("q1400");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.RptChg)
                    .HasColumnName("Rpt_Chg")
                    .HasMaxLength(20);

                entity.Property(e => e.RptLayout)
                    .HasColumnName("Rpt_Layout")
                    .HasMaxLength(20);

                entity.Property(e => e.RptNcr)
                    .HasColumnName("Rpt_Ncr")
                    .HasMaxLength(20);

                entity.Property(e => e.RptRfb)
                    .HasColumnName("Rpt_RFb")
                    .HasMaxLength(20);

                entity.Property(e => e.RptSp)
                    .HasColumnName("Rpt_Sp")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TMemProc2>(entity =>
            {
                entity.HasKey(e => new { e.Randvalue, e.Num });

                entity.ToTable("T_MemProc2");

                entity.Property(e => e.Randvalue).HasColumnName("randvalue");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CflowId)
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CformId)
                    .HasColumnName("cform_id")
                    .HasMaxLength(16);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Cnote)
                    .HasColumnName("cnote")
                    .HasMaxLength(40);

                entity.Property(e => e.Comsup)
                    .HasColumnName("comsup")
                    .HasMaxLength(16);

                entity.Property(e => e.CpaintId)
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CworkSna)
                    .HasColumnName("cwork_sna")
                    .HasMaxLength(8);

                entity.Property(e => e.D0001)
                    .HasColumnName("d0001")
                    .HasMaxLength(16);

                entity.Property(e => e.D1100)
                    .HasColumnName("d1100")
                    .HasMaxLength(16);

                entity.Property(e => e.Dep)
                    .HasColumnName("dep")
                    .HasMaxLength(16);

                entity.Property(e => e.FbDate)
                    .HasColumnName("fb_date")
                    .HasMaxLength(16);

                entity.Property(e => e.FbQty).HasColumnName("fb_qty");

                entity.Property(e => e.Field)
                    .HasColumnName("field")
                    .HasMaxLength(16);

                entity.Property(e => e.Q1100).HasColumnName("q1100");

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<TMemProdDtl>(entity =>
            {
                entity.HasKey(e => new { e.RandValue, e.CengId, e.CformId, e.CmemId })
                    .HasName("PK_T_MemProdDtl_1");

                entity.ToTable("T_MemProdDtl");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CformId)
                    .HasColumnName("cform_id")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongId)
                    .IsRequired()
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CdepName)
                    .IsRequired()
                    .HasColumnName("cdep_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CfiedSna)
                    .IsRequired()
                    .HasColumnName("cfied_sna")
                    .HasMaxLength(20);

                entity.Property(e => e.CflowId)
                    .IsRequired()
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cnote)
                    .IsRequired()
                    .HasColumnName("cnote")
                    .HasMaxLength(20);

                entity.Property(e => e.CpaintId)
                    .IsRequired()
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Csup1000)
                    .IsRequired()
                    .HasColumnName("csup_1000")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CsupSna)
                    .IsRequired()
                    .HasColumnName("csup_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .IsRequired()
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CworkSna)
                    .IsRequired()
                    .HasColumnName("cwork_sna")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.D0100)
                    .IsRequired()
                    .HasColumnName("d0100")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D1200)
                    .IsRequired()
                    .HasColumnName("d1200")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");

                entity.Property(e => e.IprtQty)
                    .HasColumnName("iprt_qty")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Netsurface1).HasColumnName("netsurface1");

                entity.Property(e => e.Netsurface2).HasColumnName("netsurface2");

                entity.Property(e => e.Netwet)
                    .HasColumnName("netwet")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.ProDate)
                    .IsRequired()
                    .HasColumnName("pro_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Q1200).HasColumnName("q1200");
            });

            modelBuilder.Entity<TMemRange>(entity =>
            {
                entity.HasKey(e => new { e.Randvalue, e.Num });

                entity.ToTable("T_MemRange");

                entity.Property(e => e.Randvalue)
                    .HasColumnName("randvalue")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMtrlLedgerBeDel>(entity =>
            {
                entity.HasKey(e => new { e.Randvalue, e.Cdescrip, e.CmaName })
                    .HasName("PK_T_MtrlLedger");

                entity.ToTable("T_MtrlLedger_BeDel");

                entity.Property(e => e.Randvalue)
                    .HasColumnName("randvalue")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdescrip)
                    .HasColumnName("cdescrip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CclassId)
                    .HasColumnName("cclass_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e._1)
                    .HasColumnName("1")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e._10)
                    .HasColumnName("10")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e._2)
                    .HasColumnName("2")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e._3)
                    .HasColumnName("3")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e._4)
                    .HasColumnName("4")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e._5)
                    .HasColumnName("5")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e._6)
                    .HasColumnName("6")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e._7)
                    .HasColumnName("7")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e._8)
                    .HasColumnName("8")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e._9)
                    .HasColumnName("9")
                    .HasColumnType("decimal(9, 1)");
            });

            modelBuilder.Entity<TOutExcel>(entity =>
            {
                entity.HasKey(e => new { e.CMemId, e.CMakId, e.CDescrip })
                    .HasName("PK__OutExcelN");

                entity.ToTable("T_OutExcel");

                entity.Property(e => e.CMemId)
                    .HasColumnName("cMem_Id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CMakId)
                    .HasColumnName("cMak_Id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CDescrip)
                    .HasColumnName("cDescrip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CBelongId)
                    .HasColumnName("cBelong_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CDivName)
                    .HasColumnName("cDiv_Name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CMaName)
                    .HasColumnName("cMa_Name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CMemPic)
                    .HasColumnName("cMem_Pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CPaintId)
                    .HasColumnName("cPaint_Id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CTierName)
                    .HasColumnName("cTier_Name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CUseId)
                    .HasColumnName("cUse_Id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongDesc)
                    .HasColumnName("cbelong_desc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CfiedId)
                    .HasColumnName("cfied_id")
                    .HasMaxLength(4);

                entity.Property(e => e.CfiedSna)
                    .HasColumnName("cfied_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ChkDate)
                    .HasColumnName("Chk_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CsupSna)
                    .HasColumnName("csup_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NBweight).HasColumnName("nBweight");

                entity.Property(e => e.Qty).HasColumnType("decimal(5, 1)");
            });

            modelBuilder.Entity<TProdProgress>(entity =>
            {
                entity.HasKey(e => new { e.RandValue, e.CengId, e.CmemId, e.CdivName });

                entity.ToTable("T_ProdProgress");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BdivOrder).HasColumnName("bdiv_order");

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CflowId)
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0001)
                    .HasColumnName("d0001")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0100)
                    .HasColumnName("d0100")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0500)
                    .HasColumnName("d0500")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0600)
                    .HasColumnName("d0600")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0601)
                    .HasColumnName("d0601")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0602)
                    .HasColumnName("d0602")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0603)
                    .HasColumnName("d0603")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0604)
                    .HasColumnName("d0604")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0700)
                    .IsRequired()
                    .HasColumnName("d0700")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0800)
                    .IsRequired()
                    .HasColumnName("d0800")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D0900)
                    .IsRequired()
                    .HasColumnName("d0900")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D1000)
                    .IsRequired()
                    .HasColumnName("d1000")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D1100)
                    .IsRequired()
                    .HasColumnName("d1100")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D1200)
                    .IsRequired()
                    .HasColumnName("d1200")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D1300)
                    .IsRequired()
                    .HasColumnName("d1300")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D1400)
                    .IsRequired()
                    .HasColumnName("d1400")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GoalDate)
                    .HasColumnName("goal_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdivQty).HasColumnName("idiv_qty");

                entity.Property(e => e.Lbom).HasColumnName("lbom");

                entity.Property(e => e.Lcheck).HasColumnName("lcheck");

                entity.Property(e => e.Q0001).HasColumnName("q0001");

                entity.Property(e => e.Q0100).HasColumnName("q0100");

                entity.Property(e => e.Q0200).HasColumnName("q0200");

                entity.Property(e => e.Q0300).HasColumnName("q0300");

                entity.Property(e => e.Q0400).HasColumnName("q0400");

                entity.Property(e => e.Q0500).HasColumnName("q0500");

                entity.Property(e => e.Q0600).HasColumnName("q0600");

                entity.Property(e => e.Q0601).HasColumnName("q0601");

                entity.Property(e => e.Q0602).HasColumnName("q0602");

                entity.Property(e => e.Q0603).HasColumnName("q0603");

                entity.Property(e => e.Q0604).HasColumnName("q0604");

                entity.Property(e => e.Q0700).HasColumnName("q0700");

                entity.Property(e => e.Q0800).HasColumnName("q0800");

                entity.Property(e => e.Q0900).HasColumnName("q0900");

                entity.Property(e => e.Q1000).HasColumnName("q1000");

                entity.Property(e => e.Q1100).HasColumnName("q1100");

                entity.Property(e => e.Q1200).HasColumnName("q1200");

                entity.Property(e => e.Q1300).HasColumnName("q1300");

                entity.Property(e => e.Q1400).HasColumnName("q1400");
            });

            modelBuilder.Entity<TQaqry>(entity =>
            {
                entity.HasKey(e => new { e.Rnum, e.Num });

                entity.ToTable("T_QAQry");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.Body).HasMaxLength(1000);

                entity.Property(e => e.CQaId)
                    .HasColumnName("cQA_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CengSna)
                    .HasColumnName("ceng_sna")
                    .HasMaxLength(16);

                entity.Property(e => e.DClose)
                    .HasColumnName("dClose")
                    .HasColumnType("datetime");

                entity.Property(e => e.DExpAns)
                    .HasColumnName("dExpAns")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(1000);

                entity.Property(e => e.Render).HasColumnType("datetime");
            });

            modelBuilder.Entity<TRptBomQry>(entity =>
            {
                entity.HasKey(e => new { e.Pk, e.Num });

                entity.ToTable("T_RptBomQry");

                entity.Property(e => e.Pk).HasColumnName("pk");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.CBelongId)
                    .HasColumnName("cBelong_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CDescrip)
                    .HasColumnName("cDescrip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CDivName)
                    .HasColumnName("cDiv_Name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CMaName)
                    .HasColumnName("cMa_Name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CMakId)
                    .HasColumnName("cMak_Id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CMemId)
                    .HasColumnName("cMem_Id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CMemPic)
                    .HasColumnName("cMem_Pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CPaintId)
                    .HasColumnName("cPaint_Id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CTierName)
                    .HasColumnName("cTier_Name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CUseId)
                    .HasColumnName("cUse_Id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongDesc)
                    .HasColumnName("cbelong_desc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CfiedId)
                    .HasColumnName("cfied_id")
                    .HasMaxLength(4);

                entity.Property(e => e.CfiedSna)
                    .HasColumnName("cfied_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ChkDate)
                    .HasColumnName("Chk_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CsupSna)
                    .HasColumnName("csup_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NBweight).HasColumnName("nBweight");

                entity.Property(e => e.Qty).HasColumnType("decimal(5, 1)");
            });

            modelBuilder.Entity<TRptMakingQry>(entity =>
            {
                entity.HasKey(e => new { e.Pk, e.Num })
                    .HasName("PK__RptMakingQry");

                entity.ToTable("T_RptMakingQry");

                entity.Property(e => e.Pk).HasColumnName("pk");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4);

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(10);

                entity.Property(e => e.CmakId)
                    .HasColumnName("cmak_id")
                    .HasMaxLength(16);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16);

                entity.Property(e => e.Cspec)
                    .HasColumnName("cspec")
                    .HasMaxLength(40);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10);

                entity.Property(e => e.CuseId)
                    .HasColumnName("cuse_id")
                    .HasMaxLength(12);

                entity.Property(e => e.ImakQty).HasColumnName("imak_qty");

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");

                entity.Property(e => e.IqtyCount).HasColumnName("iqty_count");

                entity.Property(e => e.Lcheck).HasColumnName("lcheck");
            });

            modelBuilder.Entity<TRptMemUseQry>(entity =>
            {
                entity.HasKey(e => new { e.Pk, e.Num })
                    .HasName("PK__RptMemUseQry");

                entity.ToTable("T_RptMemUseQry");

                entity.Property(e => e.Pk).HasColumnName("pk");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.CSpec)
                    .HasColumnName("c_spec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CengName)
                    .HasColumnName("ceng_name")
                    .HasMaxLength(60);

                entity.Property(e => e.CmdmPic)
                    .HasColumnName("cmdm_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CmemId)
                    .HasColumnName("cmem_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");

                entity.Property(e => e.MctWet).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.PicWet).HasColumnType("decimal(9, 1)");
            });

            modelBuilder.Entity<TRptRang>(entity =>
            {
                entity.HasKey(e => new { e.RandValue, e.RngValue, e.IType });

                entity.ToTable("T_RptRang");

                entity.Property(e => e.RandValue)
                    .HasColumnName("randValue")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RngValue)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IType)
                    .HasColumnName("iType")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumOne]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumOne]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumOne] AS 1
");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");
            });

            modelBuilder.Entity<TTestBom>(entity =>
            {
                entity.HasKey(e => new { e.Randvalue, e.ILineNo });

                entity.ToTable("T_TestBom");

                entity.Property(e => e.Randvalue).HasColumnName("randvalue");

                entity.Property(e => e.ILineNo).HasColumnName("iLineNo");

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(10);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CmaName)
                    .HasColumnName("cma_name")
                    .HasMaxLength(20);

                entity.Property(e => e.CmakId)
                    .IsRequired()
                    .HasColumnName("cmak_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CmemId)
                    .IsRequired()
                    .HasColumnName("cmem_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(20);

                entity.Property(e => e.Cspec)
                    .HasColumnName("cspec")
                    .HasMaxLength(40);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10);

                entity.Property(e => e.CuseId)
                    .HasColumnName("cuse_id")
                    .HasMaxLength(20);

                entity.Property(e => e.IbomQty).HasColumnName("ibom_qty");

                entity.Property(e => e.ImemQty).HasColumnName("imem_qty");

                entity.Property(e => e.Nweight)
                    .HasColumnName("nweight")
                    .HasColumnType("decimal(9, 3)");

                entity.Property(e => e.Totalweight)
                    .HasColumnName("totalweight")
                    .HasColumnType("decimal(9, 3)");
            });

            modelBuilder.Entity<TVuBomMakingQry>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CtierName, e.CbelongId, e.CdivName, e.CList4 })
                    .HasName("PK__vuBomMakingQry_1");

                entity.ToTable("T_vuBomMakingQry");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CtierName)
                    .HasColumnName("ctier_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CbelongId)
                    .HasColumnName("cbelong_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CdivName)
                    .HasColumnName("cdiv_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CList4)
                    .HasColumnName("cList4")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tgroup>(entity =>
            {
                entity.HasKey(e => e.CgrpName)
                    .HasName("group__cgrp_name");

                entity.ToTable("TGroup");

                entity.Property(e => e.CgrpName)
                    .HasColumnName("cgrp_name")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CgrpDesp)
                    .IsRequired()
                    .HasColumnName("cgrp_desp")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TransBomDetail>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId, e.CmemPic });

                entity.ToTable("TransBom_Detail");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CmemPic)
                    .HasColumnName("cmem_pic")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.VerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.TransBomTitle)
                    .WithMany(p => p.TransBomDetail)
                    .HasForeignKey(d => new { d.CengId, d.RepId })
                    .HasConstraintName("FK_TransBom_Detail_TransBom_Title");
            });

            modelBuilder.Entity<TransBomTitle>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.RepId });

                entity.ToTable("TransBom_Title");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RepId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cnote)
                    .HasColumnName("cnote")
                    .HasMaxLength(50);

                entity.Property(e => e.CreceiveName)
                    .HasColumnName("creceive_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Csendtitle)
                    .HasColumnName("csendtitle")
                    .HasMaxLength(50);

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CusrTrans)
                    .HasColumnName("cusr_trans")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DTrans)
                    .HasColumnName("dTrans")
                    .HasColumnType("datetime");

                entity.Property(e => e.LTrans).HasColumnName("lTrans");
            });

            modelBuilder.Entity<Tuser>(entity =>
            {
                entity.HasKey(e => e.CusrName)
                    .HasName("user__cusr_name");

                entity.ToTable("TUser");

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CEmail)
                    .HasColumnName("cEmail")
                    .HasMaxLength(60);

                entity.Property(e => e.Cname)
                    .IsRequired()
                    .HasColumnName("cname")
                    .HasMaxLength(6);

                entity.Property(e => e.CsupId)
                    .HasColumnName("csup_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CusrDesp)
                    .HasColumnName("cusr_desp")
                    .HasMaxLength(40);

                entity.Property(e => e.CusrId)
                    .HasColumnName("cusr_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CusrPw)
                    .IsRequired()
                    .HasColumnName("cusr_pw")
                    .HasMaxLength(128);

                entity.Property(e => e.DDeadline)
                    .HasColumnName("dDeadline")
                    .HasColumnType("datetime");

                entity.Property(e => e.DLogin)
                    .HasColumnName("dLogin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ichgpwd).HasColumnName("ichgpwd");

                entity.Property(e => e.IloginNo).HasColumnName("ilogin_no");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.LockedDate)
                    .HasColumnName("locked_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lstop).HasColumnName("lstop");

                entity.Property(e => e.Online).HasColumnName("online");

                entity.Property(e => e.SecurityAnser)
                    .HasColumnName("security_anser")
                    .HasMaxLength(256);

                entity.Property(e => e.SecurityQuestion)
                    .HasColumnName("security_question")
                    .HasMaxLength(256);

                entity.HasOne(d => d.Csup)
                    .WithMany(p => p.Tuser)
                    .HasForeignKey(d => d.CsupId)
                    .HasConstraintName("FK_TUser_Comsup");
            });

            modelBuilder.Entity<Usage>(entity =>
            {
                entity.HasKey(e => e.CuseId);

                entity.Property(e => e.CuseId)
                    .HasColumnName("cuse_id")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CpaintId)
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CuseName)
                    .IsRequired()
                    .HasColumnName("cuse_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuseSna)
                    .HasColumnName("cuse_sna")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nsort).HasColumnName("nsort");
            });

            modelBuilder.Entity<UsageEng>(entity =>
            {
                entity.HasKey(e => new { e.CengId, e.CuseId })
                    .HasName("PK_Usage_Eng");

                entity.ToTable("Usage_eng");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CuseId)
                    .HasColumnName("cuse_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CpaintId)
                    .HasColumnName("cpaint_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cuse)
                    .WithMany(p => p.UsageEng)
                    .HasForeignKey(d => d.CuseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usage_eng_Usage");
            });

            modelBuilder.Entity<UserBehaviorLog>(entity =>
            {
                entity.HasKey(e => e.Pk);

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.CfrmName)
                    .IsRequired()
                    .HasColumnName("cfrm_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .IsRequired()
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserEngRight>(entity =>
            {
                entity.HasKey(e => new { e.CusrName, e.CengId })
                    .HasName("PK_TEngRight");

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.IsMaster).HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.HasOne(d => d.CusrNameNavigation)
                    .WithMany(p => p.UserEngRight)
                    .HasForeignKey(d => d.CusrName)
                    .HasConstraintName("FK_UserEngRight_TUser");
            });

            modelBuilder.Entity<WebLogin>(entity =>
            {
                entity.HasKey(e => e.Pk);

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(6);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ipAddress")
                    .HasMaxLength(20);

                entity.Property(e => e.Issuccess).HasColumnName("issuccess");
            });

            modelBuilder.Entity<Weld>(entity =>
            {
                entity.HasKey(e => e.CweldId)
                    .HasName("weld_cweld_id");

                entity.ToTable("weld");

                entity.Property(e => e.CweldId)
                    .HasColumnName("cweld_id")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CweldClass)
                    .IsRequired()
                    .HasColumnName("cweld_class")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CweldName)
                    .IsRequired()
                    .HasColumnName("cweld_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LweldSite)
                    .IsRequired()
                    .HasColumnName("lweld_site")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Work>(entity =>
            {
                entity.HasKey(e => e.CworkId);

                entity.Property(e => e.CworkId)
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CFbChar)
                    .HasColumnName("cFB_Char")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CworkDesp)
                    .IsRequired()
                    .HasColumnName("cwork_desp")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CworkName)
                    .IsRequired()
                    .HasColumnName("cwork_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CworkSna)
                    .IsRequired()
                    .HasColumnName("cwork_sna")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkList>(entity =>
            {
                entity.HasKey(e => e.SerId);

                entity.HasIndex(e => new { e.CfrmName, e.RepId, e.CusrName })
                    .HasName("IX_WorkList");

                entity.HasIndex(e => new { e.CfrmName, e.RepId, e.IflowId, e.IflowExp, e.IflowSecd, e.CusrName })
                    .HasName("PK2_WorkList");

                entity.Property(e => e.CDepId)
                    .HasColumnName("cDep_Id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CNote)
                    .HasColumnName("cNote")
                    .HasMaxLength(50);

                entity.Property(e => e.CTitle)
                    .HasColumnName("cTitle")
                    .HasMaxLength(50);

                entity.Property(e => e.Cdate)
                    .HasColumnName("cdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[DefDate]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[DefDate]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[DefDate] as getdate()
");

                entity.Property(e => e.CengId)
                    .HasColumnName("ceng_id")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.CfrmName)
                    .IsRequired()
                    .HasColumnName("cfrm_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CusrExe)
                    .HasColumnName("cusr_exe")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CusrName)
                    .HasColumnName("cusr_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Dexe)
                    .HasColumnName("dexe")
                    .HasColumnType("datetime");

                entity.Property(e => e.IflowExp)
                    .HasColumnName("iflow_exp")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.IflowId).HasColumnName("iflow_id");

                entity.Property(e => e.IflowSecd)
                    .HasColumnName("iflow_secd")
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[NumZero]    Script Date: 01/07/2013 11:00:57 ******/
/****** 物件:  Default [dbo].[NumZero]    指令碼日期: 08/17/2011 14:59:52 ******/
CREATE DEFAULT [dbo].[NumZero] AS 0
");

                entity.Property(e => e.RepId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CusrNameNavigation)
                    .WithMany(p => p.WorkList)
                    .HasForeignKey(d => d.CusrName)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_WorkList_TUser");
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.HasKey(e => new { e.CflowId, e.CworkId })
                    .HasName("workflow_pk_wkflow");

                entity.ToTable("workflow");

                entity.Property(e => e.CflowId)
                    .HasColumnName("cflow_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CworkId)
                    .HasColumnName("cwork_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Iorder).HasColumnName("iorder");
            });

            modelBuilder.Entity<製作圖發圖簽收單位>(entity =>
            {
                entity.HasKey(e => new { e.工程代號, e.簽收單號, e.發送單位 });

                entity.ToTable("製作圖發圖_簽收單位");

                entity.Property(e => e.工程代號)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.簽收單號)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.發送單位).HasMaxLength(10);

                entity.Property(e => e.份數a2).HasColumnName("份數A2");

                entity.Property(e => e.份數a3).HasColumnName("份數A3");

                entity.Property(e => e.備註).HasMaxLength(200);

                entity.Property(e => e.建立日期).HasColumnType("datetime");

                entity.Property(e => e.資料審核).HasDefaultValueSql(@"/****** Object:  Default [dbo].[FalseValue]    Script Date: 01/07/2013 11:00:58 ******/
/****** 物件:  Default [dbo].[FalseValue]    指令碼日期: 08/17/2011 14:59:52 ******/
create default [dbo].[FalseValue] as 0
");

                entity.HasOne(d => d.製作圖發圖總表Title)
                    .WithMany(p => p.製作圖發圖簽收單位)
                    .HasForeignKey(d => new { d.工程代號, d.簽收單號 })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_製作圖發圖_簽收單位_製作圖發圖總表_Title");
            });

            modelBuilder.Entity<製作圖發圖簽收明細>(entity =>
            {
                entity.HasKey(e => new { e.工程代號, e.簽收單號, e.發送單位, e.分區, e.圖號 });

                entity.ToTable("製作圖發圖_簽收明細");

                entity.Property(e => e.工程代號)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.簽收單號)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.發送單位).HasMaxLength(10);

                entity.Property(e => e.分區)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.圖號)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.建立日期).HasColumnType("datetime");

                entity.HasOne(d => d.製作圖發圖簽收單位)
                    .WithMany(p => p.製作圖發圖簽收明細)
                    .HasForeignKey(d => new { d.工程代號, d.簽收單號, d.發送單位 })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_製作圖發圖_簽收明細_製作圖發圖_簽收單位");

                entity.HasOne(d => d.製作圖發圖總表圖號明細)
                    .WithMany(p => p.製作圖發圖簽收明細)
                    .HasForeignKey(d => new { d.工程代號, d.簽收單號, d.分區, d.圖號 })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_製作圖發圖_簽收明細_製作圖發圖總表_圖號明細");
            });

            modelBuilder.Entity<製作圖發圖總表Title>(entity =>
            {
                entity.HasKey(e => new { e.工程代號, e.簽收單號 });

                entity.ToTable("製作圖發圖總表_Title");

                entity.Property(e => e.工程代號)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.簽收單號)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.修改依據).HasMaxLength(200);

                entity.Property(e => e.備料圖簽收單號)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.建立人員)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.建立日期).HasColumnType("datetime");

                entity.Property(e => e.異常單號)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.發圖內容).HasMaxLength(200);

                entity.Property(e => e.設變單號)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");
            });

            modelBuilder.Entity<製作圖發圖總表圖號明細>(entity =>
            {
                entity.HasKey(e => new { e.工程代號, e.簽收單號, e.分區, e.圖號 });

                entity.ToTable("製作圖發圖總表_圖號明細");

                entity.Property(e => e.工程代號)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.簽收單號)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"/****** Object:  Default [dbo].[StrEmpty]    Script Date: 01/07/2013 11:00:55 ******/
/****** 物件:  Default [dbo].[StrEmpty]    指令碼日期: 08/17/2011 14:59:53 ******/
create default [dbo].[StrEmpty] as ''
");

                entity.Property(e => e.分區)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.圖號)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.依據描述).HasMaxLength(50);

                entity.Property(e => e.冷作場地).HasMaxLength(4);

                entity.Property(e => e.冷作廠商)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.建立日期).HasColumnType("datetime");

                entity.Property(e => e.版次)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.電焊場地).HasMaxLength(4);

                entity.Property(e => e.電焊廠商)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.製作圖發圖總表Title)
                    .WithMany(p => p.製作圖發圖總表圖號明細)
                    .HasForeignKey(d => new { d.工程代號, d.簽收單號 })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_製作圖發圖總表_圖號明細_製作圖發圖總表_Title");
            });
        }
    }
}
