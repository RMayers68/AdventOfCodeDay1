using System.Text.RegularExpressions;

namespace Calorie_Counter
{
    public class AdventofCodeDay7
    {
        public static void FreeUpSpace()
        {
            string day7Input = "$ cd /\r\n$ ls\r\ndir bnl\r\ndir dmpsnhdh\r\n272080 dncdssn.hdr\r\ndir fcnqg\r\n6067 hjpmqrq\r\ndir jvwtm\r\ndir ldztz\r\ndir lmmw\r\ndir wthvqw\r\ndir zpdnprb\r\n$ cd bnl\r\n$ ls\r\ndir dhw\r\ndir dmpsnhdh\r\ndir lmw" +
    "\r\ndir vgbqbrst\r\n$ cd dhw\r\n$ ls\r\n237421 vccwmhl\r\n$ cd ..\r\n$ cd dmpsnhdh\r\n$ ls\r\ndir chf\r\ndir mjpbhjm\r\ndir zwhpwp\r\n$ cd chf\r\n$ ls\r\n4679 lmw.wmp\r\n217367 wwnfv.qqr\r\ndir zfgznbz\r\n$ cd zfgznbz\r\n$ ls" +
    "\r\n179409 cnj.gdn\r\n171574 vglqg\r\n$ cd ..\r\n$ cd ..\r\n$ cd mjpbhjm\r\n$ ls\r\ndir crf\r\ndir hqnj\r\ndir lmw\r\n18783 lmw.rwr\r\n302608 twpq\r\n166891 vqczlg\r\n$ cd crf\r\n$ ls\r\n32183 dltmqht\r\n240428 frqqdsr.hbf" +
    "\r\n224910 sgtnrvrt\r\n$ cd ..\r\n$ cd hqnj\r\n$ ls\r\n261723 cgstb\r\n77979 dmpsnhdh.cmd\r\n$ cd ..\r\n$ cd lmw\r\n$ ls\r\n50307 fcqrwd\r\n$ cd ..\r\n$ cd ..\r\n$ cd zwhpwp\r\n$ ls\r\n141133 gdngm.mps\r\n$ cd ..\r\n$ cd ..\r\n$ cd lmw" +
    "\r\n$ ls\r\ndir dvv\r\n267473 jmqgrh.dlz\r\n295139 rrqjwpm\r\n$ cd dvv\r\n$ ls\r\n114536 gmlmbrrw.wdm\r\n102061 lmw\r\n$ cd ..\r\n$ cd ..\r\n$ cd vgbqbrst\r\n$ ls\r\n105102 dmpsnhdh.bgl\r\n269054 gmwgjf.fzz\r\ndir jbdtpnw" +
    "\r\n245266 jzsjvgl\r\n216220 lmw.gtb\r\ndir rflp\r\ndir twpq\r\n$ cd jbdtpnw\r\n$ ls\r\n27543 cjvvmzp\r\n$ cd ..\r\n$ cd rflp\r\n$ ls\r\n137601 frqqdsr.hbf\r\n83444 rrqjwpm\r\n$ cd ..\r\n$ cd twpq\r\n$ ls\r\ndir rlbsdj\r\n36846 tnrqzjdd" +
    "\r\n$ cd rlbsdj\r\n$ ls\r\n56078 bvndq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd dmpsnhdh\r\n$ ls\r\ndir fnpwwhtj\r\ndir lmw\r\n9090 mgjpsvl.jlh\r\n186374 pbb.zln\r\n$ cd fnpwwhtj\r\n$ ls\r\ndir cgp\r\n$ cd cgp\r\n$ ls" +
    "\r\n81938 hjpmqrq\r\n281971 jvszf\r\n151057 wmr.bnf\r\n$ cd ..\r\n$ cd ..\r\n$ cd lmw\r\n$ ls\r\ndir bfbv\r\n56929 pbb.zln\r\ndir rrqjwpm\r\ndir sngm\r\n$ cd bfbv\r\n$ ls\r\n92667 qrrttb.jgp\r\n$ cd ..\r\n$ cd rrqjwpm\r\n$ ls" +
    "\r\n25739 cqljn.zqw\r\n91325 dncdssn.hdr\r\n$ cd ..\r\n$ cd sngm\r\n$ ls\r\n282163 jgrj\r\ndir lmw\r\n237524 lmw.dff\r\n153497 lmw.ntg\r\ndir lqd\r\ndir szn\r\n143535 tvpvc.qpr\r\n98326 vbfgh\r\n$ cd lmw\r\n$ ls\r\n32484 dncdssn.hdr" +
    "\r\ndir glwr\r\n$ cd glwr\r\n$ ls\r\n144719 frqqdsr.hbf\r\n$ cd ..\r\n$ cd ..\r\n$ cd lqd\r\n$ ls\r\n231401 dncdssn.hdr\r\ndir jnjqmvg\r\ndir lmw\r\n199704 rrqjwpm\r\n$ cd jnjqmvg\r\n$ ls\r\n104947 trpsrfjz.brg\r\n$ cd ..\r\n$ cd lmw" +
    "\r\n$ ls\r\n230298 rrqjwpm.nnv\r\n158947 wfv.qrb\r\n$ cd ..\r\n$ cd ..\r\n$ cd szn\r\n$ ls\r\n197974 frqqdsr.hbf\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd fcnqg\r\n$ ls\r\n251609 dncdssn.hdr\r\n289497 jdjmftqs" +
    "\r\n228459 qbmthcq\r\n$ cd ..\r\n$ cd jvwtm\r\n$ ls\r\ndir dmpsnhdh\r\n47959 pbb.zln\r\ndir tlr\r\ndir twpq\r\ndir wbgcsw\r\ndir zjmldjdh\r\n$ cd dmpsnhdh\r\n$ ls\r\n247567 bnl\r\n102471 bnl.wdm\r\n80054 fhqvp.hfm\r\ndir llhp" +
    "\r\ndir mnsbh\r\ndir mpplsfjp\r\n20844 mtvl.lmp\r\n$ cd llhp\r\n$ ls\r\n180255 dmpsnhdh\r\n$ cd ..\r\n$ cd mnsbh\r\n$ ls\r\n267627 dmpsnhdh\r\n$ cd ..\r\n$ cd mpplsfjp\r\n$ ls\r\ndir bnl\r\n233742 tcnpvqc.tdr\r\n$ cd bnl\r\n$ ls" +
    "\r\n243223 fcqrwd\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd tlr\r\n$ ls\r\ndir vcsngm\r\ndir wndmt\r\n$ cd vcsngm\r\n$ ls\r\n36434 czs.dnv\r\n$ cd ..\r\n$ cd wndmt\r\n$ ls\r\ndir fvmtfcqd\r\ndir nvdb\r\ndir nwqqgl\r\ndir sbspgnpm" +
    "\r\n$ cd fvmtfcqd\r\n$ ls\r\n237025 nzttjt.rzh\r\n$ cd ..\r\n$ cd nvdb\r\n$ ls\r\n235328 dnrqwqtp.vfc\r\n51984 rhblt.mfz\r\n51332 rjhvhw\r\n$ cd ..\r\n$ cd nwqqgl\r\n$ ls\r\n203534 cjghw\r\ndir cljbrh\r\n$ cd cljbrh\r\n$ ls" +
    "\r\n133820 lmw.dnd\r\n$ cd ..\r\n$ cd ..\r\n$ cd sbspgnpm\r\n$ ls\r\n270010 hjpmqrq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd twpq\r\n$ ls\r\ndir dmpsnhdh\r\ndir hbchdjjp\r\n247649 hjpmqrq\r\n29891 rrqjwpm\r\n72407 twpq.crb" +
    "\r\n$ cd dmpsnhdh\r\n$ ls\r\n251490 dncdssn.hdr\r\n222231 hjpmqrq\r\n102058 pbb.zln\r\n$ cd ..\r\n$ cd hbchdjjp\r\n$ ls\r\n70058 dprrmd.qcd\r\n230958 tsdbl.bnq\r\n$ cd ..\r\n$ cd ..\r\n$ cd wbgcsw\r\n$ ls\r\n292028 bhtfcf" +
    "\r\ndir bnl\r\ndir bqq\r\ndir ctnlpgt\r\n247888 hblhfvwj\r\ndir hbqm\r\n277949 pbb.zln\r\n106225 rrqjwpm\r\n125927 ssqpmlfb.gwm\r\ndir zqmjwsgz\r\ndir zwwphs\r\n$ cd bnl\r\n$ ls\r\ndir fbbr\r\n240500 frqqdsr.hbf\r\ndir mzfrdl" +
    "\r\n25137 srqlww.mcj\r\ndir tqgrdz\r\ndir ztrnq\r\n$ cd fbbr\r\n$ ls\r\n84414 mjbw.dhs\r\n$ cd ..\r\n$ cd mzfrdl\r\n$ ls\r\n135647 bccwgn\r\ndir cjdptqgh\r\ndir hwdnrqns\r\ndir prq\r\n$ cd cjdptqgh\r\n$ ls\r\n147946 mdgl.drz" +
    "\r\n11972 pbb.zln\r\n$ cd ..\r\n$ cd hwdnrqns\r\n$ ls\r\ndir dmpsnhdh\r\n$ cd dmpsnhdh\r\n$ ls\r\n254432 phthmn\r\n$ cd ..\r\n$ cd ..\r\n$ cd prq\r\n$ ls\r\n75827 dmpsnhdh.rtl\r\n$ cd ..\r\n$ cd ..\r\n$ cd tqgrdz\r\n$ ls" +
    "\r\n251475 bjwnll.rlw\r\n$ cd ..\r\n$ cd ztrnq\r\n$ ls\r\n208497 bnl.dtr\r\n179376 gqnbswcj.hht\r\n$ cd ..\r\n$ cd ..\r\n$ cd bqq\r\n$ ls\r\n202201 bnl.lbm\r\n$ cd ..\r\n$ cd ctnlpgt\r\n$ ls\r\n269484 vsfvzrpr\r\n$ cd .." +
    "\r\n$ cd hbqm\r\n$ ls\r\n74455 bvnfz\r\n42748 pbb.zln\r\n$ cd ..\r\n$ cd zqmjwsgz\r\n$ ls\r\n146194 pbb.zln\r\n$ cd ..\r\n$ cd zwwphs\r\n$ ls\r\n209587 mtbzd.nwb\r\n$ cd ..\r\n$ cd ..\r\n$ cd zjmldjdh\r\n$ ls\r\ndir cdq" +
    "\r\ndir mdclfbs\r\ndir tfc\r\n132043 wrm\r\n$ cd cdq\r\n$ ls\r\n289173 twpq.mrn\r\n$ cd ..\r\n$ cd mdclfbs\r\n$ ls\r\n64639 bnl.jwf\r\ndir hpdgt\r\n72868 hznfj.nmj\r\n159467 lmw.bfz\r\n$ cd hpdgt\r\n$ ls\r\n52760 fcqrwd" +
    "\r\n54661 tzgt.hvh\r\n$ cd ..\r\n$ cd ..\r\n$ cd tfc\r\n$ ls\r\n185481 bwntlh\r\n18925 fcqrwd\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ldztz\r\n$ ls\r\n128430 bwz.fcz\r\ndir dmpsnhdh\r\ndir lbqgz\r\ndir znrnj\r\n$ cd dmpsnhdh" +
    "\r\n$ ls\r\n238193 dncdssn.hdr\r\n285939 hwfngq.dpw\r\n$ cd ..\r\n$ cd lbqgz\r\n$ ls\r\n171931 vgrp\r\n$ cd ..\r\n$ cd znrnj\r\n$ ls\r\n153738 vmwwbjqd\r\n$ cd ..\r\n$ cd ..\r\n$ cd lmmw\r\n$ ls\r\ndir bqqnsfdj\r\n163303 fcqrwd" +
    "\r\n43453 frqqdsr.hbf\r\n33319 hjpmqrq\r\ndir rlpcqtzg\r\n$ cd bqqnsfdj\r\n$ ls\r\ndir bnl\r\n2251 hjpmqrq\r\n14707 rrqjwpm\r\ndir tlnbvhdl\r\n$ cd bnl\r\n$ ls\r\n33357 bnl.fqp\r\n151237 bnl.vbs\r\n40294 dmpsnhdh.hwz" +
    "\r\n76455 dncdssn.hdr\r\n290341 hjpmqrq\r\ndir lmw\r\ndir nqw\r\n$ cd lmw\r\n$ ls\r\ndir sfj\r\n$ cd sfj\r\n$ ls\r\n156532 fcqrwd\r\n$ cd ..\r\n$ cd ..\r\n$ cd nqw\r\n$ ls\r\n59928 dncdssn.hdr\r\n$ cd ..\r\n$ cd ..\r\n$ cd tlnbvhdl" +
    "\r\n$ ls\r\n183301 hjpmqrq\r\n$ cd ..\r\n$ cd ..\r\n$ cd rlpcqtzg\r\n$ ls\r\n258638 dqt.mlc\r\n$ cd ..\r\n$ cd ..\r\n$ cd wthvqw\r\n$ ls\r\n224501 pbb.zln\r\n$ cd ..\r\n$ cd zpdnprb\r\n$ ls\r\ndir bnl\r\ndir ffg\r\ndir jljlwpsv" +
    "\r\n212081 lrzc.lhj\r\ndir rrqjwpm\r\ndir twpq\r\ndir vlgsrtm\r\n$ cd bnl\r\n$ ls\r\n124009 hjgjf\r\n74860 hjpmqrq\r\n84996 lrdl.swf\r\ndir pnzmp\r\n$ cd pnzmp\r\n$ ls\r\ndir btbtlrs\r\n128636 nfzf\r\n$ cd btbtlrs\r\n$ ls" +
    "\r\n107651 hhzbwd.wzj\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ffg\r\n$ ls\r\n57918 jwzbs.tnt\r\n$ cd ..\r\n$ cd jljlwpsv\r\n$ ls\r\n188175 dmpsnhdh.nnb\r\n46693 fcqrwd\r\n111557 pbb.zln\r\n$ cd ..\r\n$ cd rrqjwpm\r\n$ ls" +
    "\r\ndir bftw\r\ndir ccsfws\r\n87225 mccw\r\n290654 pbb.zln\r\n147394 twzqc.pbz\r\n52983 wsvgf\r\ndir wwfgbzqh\r\n$ cd bftw\r\n$ ls\r\ndir brl\r\n167154 crs\r\ndir lmw\r\ndir rrqjwpm\r\ndir twpq\r\n174963 twpq.wjl\r\ndir vnfhb" +
    "\r\ndir wcldzp\r\n$ cd brl\r\n$ ls\r\n297937 wspcnp\r\n$ cd ..\r\n$ cd lmw\r\n$ ls\r\n166695 mcjql.jrv\r\n$ cd ..\r\n$ cd rrqjwpm\r\n$ ls\r\n198762 mwn\r\n$ cd ..\r\n$ cd twpq\r\n$ ls\r\n141835 jlwf.hcd\r\n$ cd ..\r\n$ cd vnfhb" +
    "\r\n$ ls\r\n128626 tvmwhq.wfn\r\n$ cd ..\r\n$ cd wcldzp\r\n$ ls\r\ndir ncq\r\ndir twpq\r\n$ cd ncq\r\n$ ls\r\ndir wrtw\r\n$ cd wrtw\r\n$ ls\r\n133331 fcqrwd\r\n$ cd ..\r\n$ cd ..\r\n$ cd twpq\r\n$ ls\r\n151811 fcqrwd\r\n$ cd .." +
    "\r\n$ cd ..\r\n$ cd ..\r\n$ cd ccsfws\r\n$ ls\r\n100548 twpq.ppm\r\n$ cd ..\r\n$ cd wwfgbzqh\r\n$ ls\r\ndir lmw\r\ndir mfms\r\ndir pjbjgbcl\r\n204154 qtflzwm\r\n226500 vdmjj.htj\r\ndir wzqbwr\r\n$ cd lmw\r\n$ ls\r\ndir bgl" +
    "\r\n95150 dncdssn.hdr\r\n119653 frqqdsr.hbf\r\n97941 hjpmqrq\r\ndir jqthwzj\r\n$ cd bgl\r\n$ ls\r\ndir lmw\r\ndir rrqjwpm\r\n$ cd lmw\r\n$ ls\r\n233655 wmdldvbz\r\n$ cd ..\r\n$ cd rrqjwpm\r\n$ ls\r\n242918 frqqdsr.hbf" +
    "\r\n227581 hjpmqrq\r\ndir hsvnmlp\r\ndir nsch\r\n25524 pbb.zln\r\ndir qlgg\r\ndir twpq\r\n67453 twpq.fms\r\n$ cd hsvnmlp\r\n$ ls\r\n264517 pbb.zln\r\n$ cd ..\r\n$ cd nsch\r\n$ ls\r\n7898 cmsdzh\r\n233270 dmpsnhdh.bsq" +
    "\r\n101256 frl\r\n133902 jzvh.vdv\r\ndir lmw\r\ndir sgjsg\r\n130245 wcftvft\r\n$ cd lmw\r\n$ ls\r\n69572 bnjnc.csp\r\n$ cd ..\r\n$ cd sgjsg\r\n$ ls\r\n38856 tnzpz.tbq\r\n$ cd ..\r\n$ cd ..\r\n$ cd qlgg\r\n$ ls\r\n276013 frbstg.pzb" +
    "\r\n$ cd ..\r\n$ cd twpq\r\n$ ls\r\n136454 fhwz.bqb\r\n94099 rglp\r\n114026 tsrt.cbd\r\n26252 zhclpzm.rqf\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd jqthwzj\r\n$ ls\r\n128200 lmw.btl\r\n$ cd ..\r\n$ cd ..\r\n$ cd mfms\r\n$ ls" +
    "\r\n274935 dmpsnhdh\r\n76547 lchwq.dsd\r\n215701 pbb.zln\r\ndir rmwtvjt\r\n$ cd rmwtvjt\r\n$ ls\r\n74490 hjpmqrq\r\n$ cd ..\r\n$ cd ..\r\n$ cd pjbjgbcl\r\n$ ls\r\n231757 cjcpwwc.wbf\r\ndir cswvftzs\r\ndir jtvtg\r\ndir lmw\r\ndir tnctbjr" +
    "\r\ndir tqsrfhdr\r\n$ cd cswvftzs\r\n$ ls\r\ndir dchqnbns\r\ndir smf\r\n$ cd dchqnbns\r\n$ ls\r\n94111 szl.hqs\r\n$ cd ..\r\n$ cd smf\r\n$ ls\r\ndir dlnsgvl\r\ndir zglt\r\n$ cd dlnsgvl\r\n$ ls\r\ndir dsz\r\n$ cd dsz\r\n$ ls" +
    "\r\n156473 hjpmqrq\r\n$ cd ..\r\n$ cd ..\r\n$ cd zglt\r\n$ ls\r\n295383 frgg.sdp\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd jtvtg\r\n$ ls\r\n202254 bftv.rqb\r\n58419 lmw\r\n$ cd ..\r\n$ cd lmw\r\n$ ls\r\n8097 fcqrwd\r\n$ cd .." +
    "\r\n$ cd tnctbjr\r\n$ ls\r\n250830 frqqdsr.hbf\r\ndir gzrcqr\r\n$ cd gzrcqr\r\n$ ls\r\ndir fnzgsnv\r\n$ cd fnzgsnv\r\n$ ls\r\n117215 hjpmqrq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd tqsrfhdr\r\n$ ls\r\n96381 lmw\r\n$ cd .." +
    "\r\n$ cd ..\r\n$ cd wzqbwr\r\n$ ls\r\n149066 dmpsnhdh.vnd\r\ndir dpbcgfdr\r\ndir swp\r\n14495 twpq.gsb\r\ndir zhj\r\n$ cd dpbcgfdr\r\n$ ls\r\n12909 dmpsnhdh\r\ndir jvn\r\n173491 mnhpr.lpr\r\n222018 rfqfjmd.jqq\r\n205077 wbbdrpr.hzj" +
    "\r\ndir wzpbbbhm\r\n$ cd jvn\r\n$ ls\r\n117656 vqddrqlq.nfd\r\n233109 vqqvh.swz\r\n$ cd ..\r\n$ cd wzpbbbhm\r\n$ ls\r\n143534 pbb.zln\r\n$ cd ..\r\n$ cd ..\r\n$ cd swp\r\n$ ls\r\n131295 pbb.zln\r\n$ cd ..\r\n$ cd zhj\r\n$ ls" +
    "\r\n166268 pbb.zln\r\n33734 rrqjwpm.blg\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd twpq\r\n$ ls\r\ndir bppvlwqs\r\ndir bvh\r\ndir rmcdr\r\ndir tdn\r\n2230 whb.lfb\r\ndir wwtwnvh\r\n$ cd bppvlwqs\r\n$ ls\r\n195026 hvlhgsw" +
    "\r\n279259 rrqjwpm\r\n$ cd ..\r\n$ cd bvh\r\n$ ls\r\ndir lmw\r\n$ cd lmw\r\n$ ls\r\n66958 pdqnd\r\n$ cd ..\r\n$ cd ..\r\n$ cd rmcdr\r\n$ ls\r\ndir dmpsnhdh\r\n182930 grj\r\ndir pmrdhrth\r\n119725 qpcqclqh\r\n77890 sjgfjz" +
    "\r\n142855 twpq\r\ndir zbmcrvbh\r\n$ cd dmpsnhdh\r\n$ ls\r\ndir rrqjwpm\r\n188474 zgjzpbl.vgv\r\n$ cd rrqjwpm\r\n$ ls\r\ndir bnl\r\ndir lmw\r\n7598 vsntvs.pdv\r\n$ cd bnl\r\n$ ls\r\n245600 lmw.mgf\r\n$ cd ..\r\n$ cd lmw\r\n$ ls" +
    "\r\n73396 hjpmqrq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd pmrdhrth\r\n$ ls\r\n173155 rrqjwpm.pjw\r\n178530 smgpzs.qtj\r\n$ cd ..\r\n$ cd zbmcrvbh\r\n$ ls\r\n124201 fcqrwd\r\n135578 hjpmqrq\r\n54356 hnztplsp.qlh\r\ndir lmw" +
    "\r\n58350 pbb.zln\r\ndir qfrvdm\r\ndir rcg\r\n15267 rwbzjpt.djn\r\n$ cd lmw\r\n$ ls\r\ndir bbbll\r\n28362 bfgfwlf.wvg\r\n229637 dmpndms.fln\r\n146121 dncdssn.hdr\r\n131039 frqqdsr.hbf\r\n152805 hjpmqrq\r\ndir mlz\r\n$ cd bbbll" +
    "\r\n$ ls\r\n169940 dncdssn.hdr\r\n216888 pbb.zln\r\n248369 tjpmlr.vmf\r\n$ cd ..\r\n$ cd mlz\r\n$ ls\r\n115167 bhfv.fts\r\n$ cd ..\r\n$ cd ..\r\n$ cd qfrvdm\r\n$ ls\r\n284564 pbb.zln\r\n$ cd ..\r\n$ cd rcg\r\n$ ls\r\ndir sqzjz" +
    "\r\n$ cd sqzjz\r\n$ ls\r\n116435 jrstpcpl.zsq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd tdn\r\n$ ls\r\n143971 cmg\r\n133317 fcqrwd\r\ndir pstpclp\r\n133161 tddv\r\n$ cd pstpclp\r\n$ ls\r\n267351 hjpmqrq\r\n86930 rrqjwpm.dvl" +
    "\r\n$ cd ..\r\n$ cd ..\r\n$ cd wwtwnvh\r\n$ ls\r\n256584 frqqdsr.hbf\r\n114564 twpq.wrd\r\n$ cd ..\r\n$ cd ..\r\n$ cd vlgsrtm\r\n$ ls\r\n148089 bnl.jzj\r\n119796 cjfphsfw.hnd\r\n197668 cpw\r\ndir dmpsnhdh\r\ndir fjsglr\r\ndir lmw" +
    "\r\ndir lqgrft\r\n9231 pltdltrs\r\ndir rmdp\r\n109777 rncfff.fll\r\ndir vgjzqjpq\r\ndir ztnqnfnq\r\n$ cd dmpsnhdh\r\n$ ls\r\ndir lltnrdtv\r\ndir scthsg\r\n$ cd lltnrdtv\r\n$ ls\r\n179511 pcvmpz\r\n90913 tbr\r\n$ cd ..\r\n$ cd scthsg" +
    "\r\n$ ls\r\ndir rrqjwpm\r\n$ cd rrqjwpm\r\n$ ls\r\n188629 fcqrwd\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd fjsglr\r\n$ ls\r\n139754 fcqrwd\r\ndir pnsjwfzc\r\n$ cd pnsjwfzc\r\n$ ls\r\n113848 lmw\r\n$ cd ..\r\n$ cd ..\r\n$ cd lmw\r\n$ ls" +
    "\r\n54999 dmpsnhdh\r\ndir ffhcf\r\n251476 frqqdsr.hbf\r\ndir jpgqspqw\r\n198972 nhfclq.pbh\r\n180380 nqmjnvc.fvr\r\ndir pfsjwmbc\r\n213768 rcvccgcd\r\n$ cd ffhcf\r\n$ ls\r\n40478 svmwstq.sjj\r\n$ cd ..\r\n$ cd jpgqspqw\r\n$ ls" +
    "\r\n22181 hjpmqrq\r\n$ cd ..\r\n$ cd pfsjwmbc\r\n$ ls\r\ndir bcvchw\r\n$ cd bcvchw\r\n$ ls\r\n225892 bnl.nwc\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd lqgrft\r\n$ ls\r\ndir rrqjwpm\r\ndir twpq\r\n$ cd rrqjwpm\r\n$ ls\r\n54786 fcqrwd" +
    "\r\n3053 tthhqjm.ntd\r\n$ cd ..\r\n$ cd twpq\r\n$ ls\r\n109355 bnl\r\ndir lmw\r\ndir mhgqt\r\n301291 rrqjwpm.lrm\r\n271233 twpq.srp\r\n$ cd lmw\r\n$ ls\r\ndir lmw\r\ndir lngbszqm\r\n$ cd lmw\r\n$ ls\r\n139640 pbb.zln\r\n$ cd .." +
    "\r\n$ cd lngbszqm\r\n$ ls\r\n98279 mqvq.gsj\r\n283599 rvjd.dvt\r\n$ cd ..\r\n$ cd ..\r\n$ cd mhgqt\r\n$ ls\r\n208165 fcqrwd\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd rmdp\r\n$ ls\r\ndir bqn\r\n170956 fcqrwd\r\n90954 snnttp.gld\r\n$ cd bqn" +
    "\r\n$ ls\r\n75628 hdrgbrpc\r\n$ cd ..\r\n$ cd ..\r\n$ cd vgjzqjpq\r\n$ ls\r\ndir bnl\r\ndir wpfw\r\n$ cd bnl\r\n$ ls\r\n25911 pbb.zln\r\n$ cd ..\r\n$ cd wpfw\r\n$ ls\r\n247784 bzll.ltc\r\n$ cd ..\r\n$ cd ..\r\n$ cd ztnqnfnq\r\n$ ls" +
    "\r\ndir dtpzsrfc\r\n214055 srgzhp.nlr\r\n$ cd dtpzsrfc\r\n$ ls\r\n142652 bhgwj";

            string[] commands = day7Input.Split("\r\n");
            int smallFolders = 0, totalSpace = 70000000, updateReq = 40000000;
            Dictionary<int, Directory> folders = new();
            folders.Add(0, new Directory("$ cd /"));
            foreach (string command in commands)
            {
                switch (command.Substring(0, 2))
                {
                    case "$ ":
                        if (command == "$ ls" || command == "$ cd /")
                            break;
                        else if (command == "$ cd ..")
                        {
                            for (int i = folders.Last().Key; i >= 0; i--)
                            {
                                if (folders[i].Active == true)
                                {
                                    folders[i].Active = false;
                                    break;
                                }
                            }
                            break;
                        }
                        else
                            folders.Add(folders.Last().Key + 1, new Directory(command));
                        break;
                    case "di":
                        break;
                    default:
                        int numbers = Int32.Parse(Regex.Replace(command, @"[a-zA-Z .]", ""));
                        foreach (var folder in folders)
                        {
                            if (folder.Value.Active == false)
                                continue;
                            else if (folder.Value.Active == true)
                                folder.Value.fileSize += numbers;
                        }
                        break;
                }
            }
            foreach (var folder in folders)
            {
                if (folder.Value.fileSize <= 100000)                                              // Finding small folder sizes (less than 100 KB)
                {
                    smallFolders += folder.Value.fileSize;
                }
            }
            Console.WriteLine($"File size for folders under 100 KB: {smallFolders}");
            Console.WriteLine($"Storage Allocation: {folders[0].fileSize}/{totalSpace}");        // Finding smallest folder to delete
            int spaceNeeded = folders[0].fileSize - updateReq;
            Console.WriteLine($"Amount needed for deletion: {spaceNeeded}");
            Directory deleteFolder = new();
            foreach (var folder in folders)
            {
                if (folder.Value.fileSize > spaceNeeded && folder.Value.fileSize < deleteFolder.fileSize)
                {
                    deleteFolder = folder.Value;
                }
            }
            Console.WriteLine($"The folder to be deleted is {deleteFolder.Name} with a file size of {deleteFolder.fileSize} bytes. Delete (y/n)?");
            Console.ReadKey();
        }
    }
    public class Directory
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public int fileSize { get; set; }

        public Directory()
        {
            Name = "";
            fileSize = 999999999;
            Active = false;
        }
        public Directory(string command)
        {
            Name = command.Substring(5);
            fileSize = 0;
            Active = true;
        }
    }
}
