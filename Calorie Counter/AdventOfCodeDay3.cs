namespace Calorie_Counter
{
    public class AdventOfCodeDay3
    {

        public void RucksackSorting()
        {
            string collection = "BzRmmzZHzVBzgVQmZLPtqqffPqWqJmPLlL\r\nhpvvTDcrCjhpcrvcGGhfLHMlLtMCqflNlWPJlJ\r\nhGjhncHhGnhbTHczBBZVVSbRwgSgRV\r\nrWVQjPQQjGRWNSrWrPjcptwBpqqJBtJBBcZgMdtq\r\nzzmmpzfTCFpTlMlJJwBgMlqMBt\r\nTvLszpbhhTLmsnRQPDQGWDWRvQSR" +
                "\r\nzGzvLlGlQHLGBQZlhBWhdjRdmdWRcjPj\r\nfTJNfTfNSRWPhjdjfj\r\npbsbVVnpSnbVTprnbqqrzvLLgQlGLPLHll\r\nZCCCsWvNvmsCsCmZLZmgMLRpQMhwQRpQRfphfprpTfpM\r\ntlncPjzlndctbzcPPBcjwDphwrfGGDffbDRpDTGG\r\ncdqnddwzqjNVWVLZZLZq\r\n" +
                "DTLbDbRrlQbwhhNrmmfwdt\r\nzzMJMzjCjJJjvLjMPJpcgPpzfhHdfqWcqddwtwfqdttcNtdN\r\npJCzVpCvDZBLsVRQ\r\nSTzBBbJzRRBZBRTqCCsfZLtNNLClCsfh\r\njsQnnQjjHcvQFrcPwCmtLCNlvDfftfff\r\nsGFscMQQMMpqzqbMbd\r\nQlNDWGsjQjgQllWQsbtzqTJczTJcbFmmFJJP\r\n" +
                "MhLrhgLVndRmzJFzVqqJqP\r\npSLnMdwhwdRZRSwhLZwLhdGWQjlsgWjNQWWSvgBsWDlj\r\nTHjSRFSddTjdBTcPLcVVvVBw\r\nGzWnWfndWfznDfsnsBsPVwVwPPLL\r\nzNflzJWqqzQDdSStHNZNpFFtbj\r\nFSzDmsFSFlDlBzqVjqHHjHHpVgHLbp\r\nrTrTtTQQntRQnQJQgggHZttVgHLBLhZL\r\n" +
                "WTJJRRQCRRJTRdBCRdvRNDFSWFMPmDlPPSsNPSzS\r\nWQldlMtMVQgVMQHnDGbHGGnRnQmD\r\nrqcZPrCFjmHlbGjZ\r\nzSScchqwchBzTzFzhhSlcCwNtdVWWJgsVdMtWNgNVWTJTd\r\nlMZqjMWllrTTspjprWWSSwgWNSVNDmWGVwFwgN\r\ncdCCdLHcnndHJnmCRntLBnRzDvFNtNDVzgSgwDgFNVzFVv" +
                "\r\nBRLcCCJCmJdcRhfjPPZphrlrPqlZ\r\nGdGqcrrZGDrvDJJqJHcBvmFFgmFMMgMgBtMLTssLmF\r\nNbPVPDlljPmTmsTj\r\nVfQDhflCCRWdcrQwJvvnJv\r\nRLcWgLCqqPQLcqZwzHgwmmrmmtgwTw\r\nDhbhNrMpnJSDJwVTHmmTVnTTVj\r\nlrsvblMDlcWcfQPQ\r\n" +
                "PVldlphHwGwJJGdjZZWsRbbsGsNWrWQbNbQR\r\nSqcDvTmDLtfmSmtqppfqzTgTQBrRQsbCFWbNNFQFBBrRbLNb\r\nMgtmTgtfpqVlnVddZMwV\r\nBdmfmPBPSbSNdGSdvWrwcZrccZPPcZnH\r\njzzLsjsMRlQQVHwswvvZrCHrrT\r\nVqhzVFzplFlpLwpMphLRQQVRmSqgbdGtNJBmNSmgGbtggSgt\r\n" +
                "DHVpNZjdZjFZWVFHpvFvzmlRzPnlfznFRz\r\nlrTBTsBwwMbrrwLPPfwGmGzvRf\r\nscrtMhMCtJBBBclbHdHttWZWDSqDSjHj\r\nwzqsPmqsbsfqBwPMNRMMZcZmFFNtZM\r\nCgCnhlvvLJgcRFNNBdCpWM\r\nQnQrVgHSvVHjbjTGBbbTHb\r\nHdrVrdqFDdZVmHgRmDRFHMnTdTssMGnLnPJLbPTbCs" +
                "\r\nSczlScjwcNzplNzQSSfjwQSrTGGsbTsnTCnGTMCMLMGGbN\r\nwQlfjrhfhQFHqZhRZRtD\r\nRsfJDGJvzPNcjpddSWJWMd\r\nLLCbBCwCrCmVVnrmhQFmbVhdcdlWpjZzSpMdWSpcWczSBj\r\nrrLCbTwnHTvzvNGT\r\nwPhPhbCqqSCrtJDlqvlrJr\r\nRVVZddLFRZZcQLvJJtzptlgPJp\r\n" +
                "TVQRZGVncFdTGWZdCNShHhfPNwwsWPwb\r\ndzLVzPSgrgDDDCMSMLLPwFmdTTcsvmwNwjNsHcFF\r\nnWBGntQfGNGBflWBBqlpRQGbWFvjwsbsFswbvTHjjbmHTc\r\ntBNJBnGBflQnDPJrPhDgrPVg\r\nVtWztWtqpqzWpWzqjNRjNpWTmrrmrSbnmJwSJwnMPrCSJVwM\r\n" +
                "sDHsBDhBdsBZGcHvLHDLhhCSnRSwCJMZrPbmnMbJSCSR\r\nccLRhgsLBdRsdHNTFFNNgqTglqzF\r\nhztlmDhPhgPlPNNgmZMCbmwwQjcwjjwMjVCd\r\nRSJRrRqnqQJFqvnTGrHCcHHCCHHbHHMcMvdM\r\nqGJsnQTRsStsftPlhPNl\r\nBFFBLPRCwsLwhlPlRmhcGGrbmmGjfNTTnp\r\n" +
                "VJMVpzgqggJnrjmjNcMjmT\r\nVqdSZtQgZvtdzqHqHtVZdVQpCDWWFdwlRPDpWPPBCswlWD\r\nfCWCsjPzcbzwRSzVTzhhDLqvdg\r\nTmJtrNJrBLSLJqgS\r\nptNTQFHrZlnpFPwsWMbRjCpcjR\r\nnJmQNCmbmlllmbClbfMLjMFqbGBsdLFq\r\nZcgTWcTnMqqMTBqF\r\n" +
                "tPgctSnPctZZgDWzZgQHwNmHlhlmzlQhlJlw\r\nZpTCwpffdslvgShCBhqhRz\r\nFDMPnNFNmBPzvRPRBg\r\nnNgMrnnDGjDmJMmnFdZTTsdsrZrslcwcQr\r\npTmczpCldcdDDnPttpvWSqbpJf\r\njgjRZMGHhGLgQrjvPWzPJgJvzStbbq\r\nLGNLLNBBzcDFCBwwFC\r\n" +
                "nJTTqnrNvTzNMzzNfqrTPrJnwpwPpZpsHccZVsBRpcVHwpcp\r\nbgDhgbghLWmFmStctVpZtBCVCCpfZp\r\nLLSgLGSjggFGbSSbmMnrvqvzjfzTNrJrqM\r\nRRpDmmPMTjwfGmJQgQ\r\nWsNscdnvvdVZFVnnrZbjjflwljlbzfGFjQjq\r\nNnLZsNnrrVVVcvdBLTPCPCRMwhPMBMPhCt\r\n" +
                "lbVvzngGJnVbJHpHtHNPpdSQvc\r\nTsMBswFZsWMWBZMNwPtNNtRNHcNpSQ\r\nCcZCTrZDsjZTsTsshWhrWrTnfgbLDfJzVVLVVlgfnzfVGV\r\nJzTTRtJRZWmWjrMHCT\r\nDDFGlLGcGlSSSLsFGBspPBmNMBHMghmWNmWjWCmWtH\r\nnSSpnbsGlLDnpPsSSspFtVvffRQdVzqvvbqdfVQwRz\r\n" +
                "sMhzszlHHDsWbthHDqsbJjpLNtmjVJmVLLVLVLBp\r\nnrTPrGwfPLdprzJzdL\r\nwgPQcTGGzgccwCgnRwgRChFhlWSDqWWQMWhssSsMQl\r\nNSNmwtpSpCpvMphCsr\r\nPHcRGPLJMrsvzsqG\r\nQHjbnRMcfbPbQZmlZgZlgBBQ\r\ncPRPbhQjbQRdtPQdLqLHqzFZjCFCqLjC\r\n" +
                "mmfsnnwrfvwrfSNZFzHHLDCFNlLlqDlN\r\nwsmrwswwGTffMrBnmQttJtcMZQQtPJPbZc\r\nMvBPDDRRdnnvHPCHZLHZsFLL\r\nrmJcbVqbcjWwWjQHLzTZFTHSzFrpsz\r\ncmwllVqqGJbVVVmmqbQcmgRnRvGhGfgDRDZBBBvRdd\r\nnMvMhMnvhnbTZWSSZgHmGJDFmmNDzBmbNmdGBN\r\n" +
                "rCsPLRCssRjrLLsrLlwRVrcNJQfDQfdBmmfNBGJNzmDPfB\r\nCRjCpLltgtJgJJWq\r\njshCzJpjzTPpmCWvSlpfwHfSWglf\r\nLQMMNMnHtDtLVRvwwgRWlldgWD\r\nqHVrQNHVMFQtrrBBQMBcrrZsZbzCZhbbJZJsmmsmFPTC\r\nJZQZnsQNMqTngZqJBVfBfPPVBNrwvfPw\r\n" +
                "SSmDstFjpDpCszDjcLLhrPVlGlrGGVBwrvwVPt\r\nFSssFcLjFjbmFFCzjLcFLRDnMJnTHRnZZTdWqZZWnMnRnZ\r\nGbHRHpldwGMpWhHpCMBlCbRdVSLhnqJLSrDPLPPLPDqVDrhh\r\ngvjWWQvgZFtQFFNqLnVnDnSJzzztDD\r\nZccccfTsffHdWWdRWwsw\r\nClCtbHMlnnPPlszV\r\n" +
                "gSDWSLgWQWQJJNWqgtQjPsnfcdVcLVdVdzfzVzff\r\nWQgqtFQgDgQSFqJhqhSJvNDRrZMZHwHMCbZhTpZbGHMTMG\r\npZJZlCQtHFhPfdNfCh\r\nzcmLSVczwcMcLDNFHdLPhPWH\r\nszvVVnBmnTGQtHTQ\r\nRVVCNDlNGzlGZqHGHWqWhGqQwH\r\nZFLFTmpLvvmSqsbb\r\n" +
                "TrfpBfJpJMlnnNfNZD\r\nqHHlDClHhltMqQsHDhHslGznwdTnzzwDGSdfnwGnwG\r\nmZRNcNcLLPNPBFFbbPmLmbZFSCVfJJTVndVfSwnRzznfTwCS\r\nCcCWFbbBLCWtgWgHjghqvv\r\nTjbzlnlFmfqCFFVVCRWr\r\nPhMcLpPDtMLpwPDvLPJbMhSgVCGqggVqQgCqCgCgSWvv\r\n" +
                "btbZbNZhJDJJhDtwtsTTTmBzzBBmlNlmHj\r\nFqhjWtqlqmmsnFPTCvMCQMTTCjQd\r\npfffRfLpgrgGgzrNVzzpGVzRCdMCPJbwwcVMbQPCJVMVdbww\r\nDGGDZRGrHggzSsFQnnWShmtH\r\nvtHVVMMrvVMVrSHvLgvlHcZFCnRCZcccZtRRZfJFCJ\r\nrdDjGsdTQDcNZfdncCRR\r\n" +
                "rBDsTwBbjbmbbQswswPhqVmmSvpVhlvvqMhHhh\r\nvGBLrqMNvqSLBvvrNbllLHfwStWWtFttccjtRtjtcj\r\nMhCDJmhMDzmcRRcjzWfztH\r\nZQDmDhVVCQbBVdVNMvvv\r\nptCtCzhWPWptnhVzzpGZbZTjTjVjFGjVFgVl\r\nfQswRRffmRqZlgrqqFjjSgGg\r\n" +
                "HwsQDNNsDsmRLLHmffsfvHptBnhtzCvhWpZWBdhnMdCh\r\nRlHzzTqczBPfbnvcpB\r\nwVtNwpSZstppwwMsZhsdnLvnbtBBmbnLFFdnmF\r\nWNQJMVWsZWwGJWhhSNrQzlgHrDCgQRHpCHrl\r\nRrZWpJZRrZpdTGstlchLGGlLMd\r\nNqjDPCQPnQCSvtMzSLhhjM\r\n" +
                "nQVQDDDDfwBwNCVCNVFNpWpgJgrRTmLTmTmgRTWF\r\nSHMcrMHpcjGcjSrMMbvSvvSvwFTLJwJNtFGFWJNtDLFTLfWN\r\nzqRnPfzQCRzqsmRPzznhszzLtLwQwwFTgWWLDLgWFTwTNQ\r\nqVPZmRZhsCZPhZlRCqRRRCbfpccMBjvMVjdHjjMjSvdf\r\nVVQdHwBZLVltlddtBczhrzvGcWWFRwgsFG" +
                "\r\nTDTTTqqTSSqjqnmTmPqPPmTmGhRszvsrzsjRsccgzrRzgWGF\r\nDpJPqpWqHbZpllpt\r\ncCSCFsnnZFnscDtNdJFJtJtdmb\r\nVgBqBsqRrHtNdzmNrt\r\nBGLLVVjRBsqPBfsGwPsMfSSZCSfTZTZQpSphfS\r\nplCHCHlgglHHGpNbtngNrDvBDpfQDBQfZDfWZVrr\r\n" +
                "mTmMLhRfwhsLPQvQZDMZQBQWMB\r\ncwsssmqRTFFfFgtbCtGl\r\nLQPPrCPnMZwqtRMn\r\ncWTSlJWlcplJdDTdGdpDlGcGgqmtwwZtqRrNRRmRdNZqmgNq\r\nGSJcJSjsjTpsvWGWBHLLvVVBBBrFrzVz\r\nNVPCSPMNDSNFVSWCsJJJmpGmZZGLLcpZLHGGtsHt\r\n" +
                "fwzlBBqghqvzqqlDrHbpHjZHmGZbLZrHLb\r\ndnBgnDqQvwRnSnnFMFMP\r\nBCbPsFFwCRHmDSBmWnvDDj\r\nphhZVzdpVfQZphhZpRhSVnjmrcvvnrWtDrvWDS\r\nTfQJMfLphMhJdfdzpQJRTPbwHHNlgbGwsTGgCP\r\nttWLlnnvnNnBBtlTqWlpvpndQdZsQQFssFDdsRFdVdRNFQ\r\n" +
                "jSgrScrbGZSGrrCGsFVMssFsPPFcDDMV\r\nbzSmJbfCZCbzLwllflwqtvvw\r\nzmFTJwFLPmzLztmjDzTJwfNrdFNrFppBSNRGNGdbrpBR\r\ngqlhWQgsZMsvqMlMMvsvqsNlLbcdppbrRpdbbcSrrbbr\r\nvssCgVgCsggZQZCgsnsqWgWvfJPDLwffwTPPmzTnjTPmPmwJ\r\n" +
                "SpcRTPQLBLWpNNzjmmwwwRrR\r\ntGlfvGhfnbDlbqlChnfFMrwsmwNssTMHMHjFwv\r\nZlhtCtffCdWcZWZVVT\r\njTTCcWHWJNgCGTzTmnzrmnGn\r\nBwRRbFvtvvQmJJFMpMJr\r\nZBBwLvqbBZsRsbVsZSqbcZdJjHHjhfPCJfJfHhgc\r\nVrnDSvvrLrfTdTLGfdRp\r\nzcJzmcFcHGfdGmWTVd\r\n" +
                "tHsMhwPVctccHFHFcbSDbbPjnNbBnbvBQB\r\nQttWQwLTnLnWTtnffnLQSBFVjNvBjBFNgMdCsVWsjv\r\npDqcmmRPHqgVBddjvN\r\nDcclzbcbPbJLnNTfnw\r\nplRcpsZDGlGZvWvMCNcLtttq\r\nSrfrwSjSVrSjwbmSrHzmHJCQQPQzqttNNQJMzJtqMW\r\n" +
                "wSHVnfHfWwwHWFVfSnfgmmRsslFZZDBBGZsZsDTdGRTp\r\nqSFQSgQNgQBrBHHcrW\r\nVTmjVJLTwlTmwTVmsMJMVlJmPvcbvvbCBbGBPjGvBbBGWcbb\r\nDnJTZwmnZRhnpqNdWt\r\ndTVHjZLLZDVCfVHtLDDjQbscjWbSJMJPjsbWWb\r\nFnqrnmzzFllmsWwtsFtQMMFc\r\n" +
                "lmqzzzngGmlNNBqGllzlBNRvptHHpTCHpDLpgDZdgvHvDD\r\nsdRZQbCfZTSTdlfTZCffccWPHPPcPPwLwctRnLWn\r\nBBJDzFVgCDrCJrqDJJhqJVVMLPHwcctFwcWHHGLcwGwGHnWc\r\nghpJgqqjCZbQdZpd\r\ntbcpzbHSszcHBgqHGZgJJJhhww\r\n" +
                "jfvdvRTffQQrrFCRFTnGwJRqNRZVpJGZLZggLh\r\nnQTjTnMndlTdQFMvnrClCnpzmzDtbbmBbcPSzzlmmtzP\r\nBqBqTCSTcqHsJHHM\r\nWWPGVPLtzVgWtjWPGzVjzVGcbDhPsRbDcsbJwNRswRDRss\r\nVQfWjfLFGWLjdFfVzTZZpJTpnmlTrSQlBl\r\njLNsZjqSHCsGdsmpsm\r\n" +
                "MvnVFzWMwMVWzfnVDwfBMfnnrCtdtPmPlRrdrJCJrtPDrrPD\r\nzznfFWwMfMfFMwVTMQFnQjhjgjSZhCNbLSTcHHgbbC\r\nGGtssttVmvnnGNMQrrVzgwVrCWMz\r\nFdhfhhcCDhHLfzclZMcrwcQMZM\r\nHHqqCBhHSSpdmjGqmGjtjtjj\r\n" +
                "bbQLtGMQQtQRQtrDtGprrrbCqwplZhhqSqmdwvdzqqqhSmpS\r\nFsJjJBfnsJcFcFfjVPjWBzldqhqnlZZZzzhmnSvSnm\r\nJPcFfFWjFHJVVsVjPVscsDlLNRHGDbLRMRCDNrCGbG\r\nJdMdlMRJnTwdvcjv\r\nCDLHbNSzzLFgHvnTjrswBNBTNT\r\nQgbvzSFQmZQPQQRW\r\nNTBrNzrpjjjCwGbB\r\n" +
                "FRbQlcvFvcRQQlRsMlRRRZjwCqMwjmjwJZdLJmjCZC\r\ncVPPQcvlWDNhrbPz\r\nVdbVtbbZJdtJVVdDVZmTLqqTSQvNLjjDShhvSG\r\nzplpnBnFpnrrlghGNpLNqHvqvjNj\r\ncWncllnlPFWzcMwtWWtsVLVRmJWCds\r\nShLSTnZnTSttTSbLQdfSZTMwcDHwwcHnJvDHnlnlclMM\r\n" +
                "NmPMsssRrVwjDclHJwwR\r\ngNNMWGzNmqGdtfZTbGGb\r\nsWNNlRHnmJtmntJt\r\nbrbbBTbbFbCbqqGgBTrCfmQVVZfSSQQSVtJZSrVZ\r\nbbFqvbDvvGGLGbCCtBGDLbLlcPNHhhccPNcdPPchlsdR\r\nDCFvDvnCnNfMBmMMslDZML\r\nSQQQJHwpSgJSJHQWSWHqJWWbmcBBBLLTsmhhTcZbMhmlshcb" +
                "\r\nRJRgpJHssgwSQHRqsQPGGjjtNCrrFvvnFjjPrP\r\nmThmsgjzTPjMpcvtWP\r\nGNNBVqVGNZbbNbNqqZQVNVNbWcpdtMCcpCtMWCdCPpQccmpp\r\nVSmNrmmbBfZVlsrssrLTRhRhTn\r\nTdmCvLDCpTRNTdFbbWnnSWCfhjbbzn\r\nGrrMsPVGcQHBGMbhjjSgWfHHDbjb\r\n" +
                "BPBVqqrQPsQqwrrmmmJdRLDDqFRplT\r\nfpDDJljDlCfDTjprjrfbddWthCSCtdPPQFhSSSWW\r\nHsLZgMGbgBBsNzMvGbdVtVQzFRQSthhFPdtP\r\nsMBmGBmbNvLHGMnrDppTcJmcjpqljf\r\nptSpSJQqpbNGGDDhcMWrlNHcZZWWls\r\nzRLRRRjvvgjHMMsMpWpc\r\n" +
                "vmCPLCgwvwdnCzmvLbpTbVQqJJPbJPpTVq\r\nTJCfhhJVFffrJJQQllNWcvWhwvWD\r\nGPSGjjpLslBbpLpLqqqPDvdwvwvNzQWGzDDNdzGN\r\nmsbRjbpPqsRpHnlZrmJlnVHT\r\nGGfFsCCTvGDsfTTrhsCMMzptZJMdpdgtrpdMcV\r\nLBlwBHPSqjwwlVggHpnMZcVHMt\r\n" +
                "ZlZZlBbRPGGTGfmRsD\r\nCtCjbVvzQQZTWVdd\r\nMlSqWlmsmGBSHJHTDFHZ\r\npcqsmsplwsqclwRtRWgtRnPPvb\r\nzCrzCrsdjrhGDCFqGDjRRPtpWfQQcpfQZcCZPp\r\nVSVwVMgLHHLTwMDTMMVnbWPRZQRcRQPptWnpbZcb\r\nMNBBBlSMvLVwTlVTFdNdhNhFsqsGDrzm\r\n" +
                "rBLWTwTThWwVVDTwHBsZZWppvpGtpptppmRvFFFMFMfL\r\nqPPNCCbqcbcNqbqQjjJQqzjRpptmlpMGmMlJtftmtFHpMt\r\nQnCgzzQbbQqPcPQnncbdQdnVTwDssZgrShBTVgZZsBSDHT\r\nPFGJFqnfqmPgFJQPWdbLdpDRhbphWjDm\r\nrclNHvcrzCNwrWRprjdMMMph\r\n" +
                "wsZHwZNvRRQsQqBV\r\nLqlGCPlPLTCPqqQlpqLlWfBfWgcHNRJRfWNsncGH\r\nVVtdwVtDDdVmhrdwSBmjbdzNHgfgJnNnsSnHsNffHgRsgR\r\nwVzhbjmDbDrwjdbztFDDthMCvqPppZQBQLZQTqTvFTvZ\r\nBnQnQFwRmRwmwdBSFDFnmSDVLCJTCTppVVmGLVTCLcgVpC\r\n" +
                "ZlWvhvZjNrbNvqjNhlfPfqjCGHrsspggTpVLpsJCpcJVgg\r\nvPzNvqjWhqFzGSnRGMDG\r\nwZnMZzzZZchDRtVsqtCtwV\r\nWmWpWWmPPWrmrmBmWrTlTFPNVqVCRSDCQHcqVTtTqsSDSTSD\r\nPrppdFlWWlfrWmpWFffrdcGjJJGggnnhZGdLLgGGndvz\r\nFShHNmNhRhNJmBnQBQJrmP\r\n" +
                "VTgzDTjwfffwzDvwlcczzVSJbQlBQSWBWCnPJPbJWWbC\r\ntzSVtzvSvGSRZqqFMNtpRR\r\nhPZhGDZpnCGtDhznjmLmdJffdNzJ\r\nglwsSrQwBvLdgLzdcj\r\nQsRbHllzzlHwHlBszWlTBFbpDPMhbPDVGpGFpPtFPp\r\nSRjStRDctgDSBzLvPvNrDhmPLr\r\nQqTHGTPJmmHmhNmH\r\n" +
                "TGQZsTqFnQZCJTPsnJnZQMjVRBVtcVRSVRBlwccSCtBS\r\nbbsNsvsvnNPTRRllbblLqhtQCqQSLCGGHSqHNC\r\nwFpzFgqVzqVJWFDwqJDmSBBmHBHhShLQhCGSBCGH\r\nMJVpFMqgwMqRRbZsMbZMrP\r\nPPdDhvNDQdmgQPZmQVHHtHGGWVGbffWGvs\r\n" +
                "MMLCTRRLlLclTLRMRLCwMLHWVctbVVHWWWFfVjVGsFWW\r\nMRSMMlpTJRqClBCRqBDnzqgQPnqgznZPZqbP\r\nMrMNPNNpjvdprWtrpMsthqBfqlnfqcGhVBqFRcnqFG\r\nQbDgSSQbgSDDmDVmlqSCRllRcFqnqfBl\r\nQVJbVmwwDQbzVTgbppNJNMWNjNNPrdpM\r\nWwJJNbtHfpLpVgZZPVFhZh\r\n" +
                "vmmqlDvRvRfqBSrlzmmMjRBhcVhQVZhVghCQQQQTcTrPTP\r\njSqMmqRzMDDjvqlBqsBMBmmwGNJwJnwLNfbGwddswnJtJH\r\nRLgRmRggbvbzzPmmRNmzsQWFtSGNtwSNQnntFwnnCw\r\npDBrBHpHhlldphHBHhJVFSLnWWFJttCtQSttSS\r\nhfHrpphHBppfTvmzgMmbLbgf";
            string[] rucksacks = collection.Split("\r\n");                                            // Method to find matching types in one rucksack 
            int sum = 0;
            for (int i = 0; i < rucksacks.Length; i++)
            {
                bool foundLetter = false;
                char letter = '2';
                foreach (char x in rucksacks[i])
                {
                    foreach (char y in rucksacks[i + 1])
                        if (y == x)
                        {
                            foreach (char z in rucksacks[i + 2])
                            {
                                if (z == y)
                                {
                                    foundLetter = true;
                                    letter = x;
                                }

                            }
                            if (foundLetter)
                                break;
                        }
                    if (foundLetter)
                        break;
                }
                sum += Dict.typePriority[letter];
                i += 2;
            }
            /*string[] rucksacks = collection.Split("\r\n");                                            // Method to find matching types in one rucksack 
            int sum = 0;
            foreach (string ruck in rucksacks)
            {
                bool foundLetter = false;
                char letter = '2';
                string one = ruck.Substring(0, (ruck.Length / 2));
                string two = ruck.Substring(ruck.Length / 2);
                foreach (char x in one)
                {
                    foreach(char y in two)
                        if(y==x)
                        {
                            foundLetter = true;
                            letter = x;
                        }
                    if (foundLetter)
                        break;
                }
                sum += Dict.typePriority[letter];
        }*/
            Console.WriteLine($"The sum of elve's badges is {sum}.");
            Console.ReadKey();
        }

        public class Dict
        {
            public static Dictionary<char, int> typePriority = new()                                             //Dictionary for type Priority
        {
            { 'a', 1 },
            { 'b', 2 },
            { 'c', 3 },
            { 'd', 4 },
            { 'e', 5 },
            { 'f', 6 },
            { 'g', 7 },
            { 'h', 8 },
            { 'i', 9 },
            { 'j', 10 },
            { 'k', 11},
            { 'l', 12},
            { 'm', 13},
            { 'n', 14},
            { 'o', 15},
            { 'p', 16},
            { 'q', 17 },
            { 'r', 18},
            { 's', 19},
            { 't', 20},
            { 'u', 21},
            { 'v', 22},
            { 'w', 23},
            { 'x', 24},
            { 'y', 25},
            { 'z', 26 },
            { 'A', 27},
            { 'B', 28},
            { 'C', 29},
            { 'D', 30},
            { 'E', 31},
            { 'F', 32},
            { 'G', 33},
            { 'H', 34},
            { 'I', 35},
            { 'J', 36},
            { 'K', 37},
            { 'L', 38 },
            { 'M', 39},
            { 'N', 40},
            { 'O', 41},
            { 'P', 42},
            { 'Q', 43},
            { 'R', 44},
            { 'S', 45},
            { 'T', 46},
            { 'U', 47 },
            { 'V', 48},
            { 'W', 49},
            { 'X', 50},
            { 'Y', 51},
            { 'Z', 52},
        };
        }

    }
}
