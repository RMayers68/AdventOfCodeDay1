﻿namespace Calorie_Counter
{
    public class AdventOfCodeDay1
    {
        public static void CalorieCounter()
        {
            string calorieCounter = "17034\n\n13495\n7368\n13905\n\n68034\n\n7796\n10348\n5088\n8836\n\n15061\n1842\n7047\n\n2477\n6629\n7998\n4235\n6505\n2875\n6059\n9423\n5315\n\n4054\n6388\n5278\n4163\n10438\n10821\n2650\n\n6424\n2420\n10363\n4275\n1876\n" +
        "6357\n6364\n\n5123\n1271\n3991\n2792\n2513\n4890\n2900\n7820\n6020\n4612\n3109\n\n9072\n18898\n13848\n11609\n\n1793\n1434\n2288\n4573\n5087\n7366\n3233\n3052\n5754\n1418\n6255\n\n5372\n2497\n2289\n6782\n4154\n5081\n5984\n3164\n4111\n2951\n" +
        "6928\n1798\n6525\n\n19803\n23713\n7818\n\n7662\n2324\n8206\n5409\n8225\n5513\n2664\n3870\n1428\n5189\n\n5603\n8006\n1486\n1469\n5413\n5638\n2242\n8559\n6333\n1389\n\n4187\n2794\n1067\n1632\n1679\n4572\n5964\n1170\n4199\n5612\n6321\n6658\n3737" +
        "\n\n2093\n2221\n4741\n5892\n3781\n4034\n1030\n1542\n1547\n5429\n1896\n1371\n4041\n2522\n\n15827\n1404\n8514\n8983\n6878\n\n56181\n\n11350\n12192\n12659\n9552\n14896\n\n5308\n6289\n5069\n3594\n1499\n1034\n5546\n3430\n2292\n2825\n4427\n2315\n" +
        "2738\n\n5102\n3295\n6423\n1653\n6199\n2459\n1569\n6588\n5691\n4490\n7235\n\n6470\n9298\n10054\n6316\n1773\n6657\n4398\n4420\n\n25785\n1283\n\n9366\n10257\n3221\n2899\n7247\n4711\n\n4108\n6265\n4824\n6589\n2869\n4826\n5853\n1770\n5627\n6581\n" +
        "2591\n2107\n\n1300\n1774\n9933\n6743\n11425\n8454\n8080\n\n1292\n6230\n1017\n5895\n2718\n6219\n5511\n7161\n1201\n4493\n\n3268\n1306\n5417\n4691\n13018\n13021\n\n9165\n12000\n7531\n10585\n2802\n10764\n2744\n\n8261\n4961\n3019\n3309\n6632\n7955" +
        "\n3538\n7392\n\n2730\n4479\n1909\n6013\n5214\n1188\n5074\n1589\n1103\n1393\n1745\n4162\n4231\n4197\n3307\n\n1246\n5200\n2648\n6419\n5659\n7380\n4479\n4589\n4108\n7290\n5514\n4406\n\n4256\n5658\n9668\n8745\n6698\n11874\n9277\n\n19436\n11206" +
        "\n7547\n1540\n\n4757\n11223\n9685\n6113\n10587\n5328\n1896\n\n3312\n2758\n3528\n3501\n1933\n5876\n3471\n1208\n3892\n5302\n2674\n1282\n1195\n5675\n5753\n\n3127\n21845\n\n5244\n9557\n8744\n2783\n6549\n6225\n1122\n7317\n7574\n\n5154\n2790\n3239" +
        "\n6496\n7433\n5770\n3835\n6644\n5503\n1273\n1244\n7098\n\n4307\n1882\n9426\n7432\n3558\n5765\n9957\n6974\n\n9510\n35767\n\n3109\n5208\n4756\n1226\n5645\n7133\n2308\n5784\n5194\n2739\n\n1850\n9199\n6957\n6793\n9231\n9094\n7275\n2519\n\n52651" +
        "\n\n2337\n6455\n5574\n3001\n1296\n5120\n5175\n1704\n7041\n2118\n3446\n2219\n\n10123\n2817\n6853\n11370\n9490\n\n11194\n1887\n1922\n2390\n10687\n3573\n8476\n\n3646\n1365\n5255\n1882\n5705\n2428\n5833\n2242\n3674\n2254\n5141\n1317\n4873\n4421" +
        "\n4178\n\n7264\n12898\n4423\n1871\n4998\n10540\n\n9143\n9081\n6136\n6734\n6955\n6956\n5693\n8110\n\n8820\n11554\n5474\n9848\n\n7445\n8434\n7883\n3523\n2562\n5174\n3178\n5766\n5322\n5347\n\n2666\n1556\n4772\n5053\n5874\n5711\n1684\n3351\n4037" +
        "\n4770\n4755\n6280\n1326\n5756\n\n4322\n10058\n6727\n3217\n9987\n3195\n10711\n5728\n\n8382\n32068\n\n3385\n1384\n3110\n1205\n2932\n4065\n3886\n5950\n6443\n2657\n2229\n4438\n2100\n3961\n\n1654\n2028\n8414\n3662\n4270\n3923\n4827\n5443\n2710" +
        "\n3406\n\n8262\n6401\n2115\n7528\n1359\n1934\n1560\n3271\n8459\n8387\n\n8437\n5394\n5589\n5243\n3421\n5228\n3601\n\n6306\n5779\n5119\n2453\n1289\n1164\n1175\n7252\n7215\n2632\n6832\n2304\n\n4788\n3723\n5887\n2748\n7350\n5974\n6015\n1545" +
        "\n1092\n2524\n4130\n7297\n\n3455\n5668\n1435\n2738\n5520\n4374\n2594\n4144\n4457\n6479\n1230\n3682\n6157\n4284\n\n10449\n6988\n2505\n6083\n3844\n2655\n8953\n\n6061\n5493\n4922\n3375\n1273\n4181\n4643\n4039\n1482\n5952\n3468\n4719\n4101" +
        "\n4702\n\n1135\n3886\n3308\n3986\n2662\n1814\n5813\n1079\n4916\n5059\n2155\n1404\n2398\n2730\n1972\n\n5868\n5201\n3725\n4905\n1655\n3585\n6339\n5563\n6869\n4779\n4072\n5106\n3587\n\n5997\n1240\n2115\n4558\n1572\n7031\n1568\n3230\n4081" +
        "\n3767\n1916\n5388\n\n6672\n7355\n7362\n6232\n6112\n7095\n5350\n8343\n8171\n8331\n\n4370\n11625\n6923\n1583\n9520\n11093\n11708\n\n4475\n23713\n\n6310\n6536\n3243\n2910\n2861\n5076\n6562\n3924\n5933\n4044\n1572\n2351\n6665\n\n6994\n5704\n" +
        "5165\n7364\n5819\n1816\n3929\n6967\n1009\n2528\n6107\n6954\n\n6855\n11865\n9195\n18609\n\n5582\n3987\n7772\n2106\n1006\n5441\n6201\n7748\n1386\n1898\n7790\n\n5332\n5371\n3515\n6367\n6657\n2677\n4790\n2448\n3401\n1668\n4425\n3758\n5385" +
        "\n\n4105\n3883\n4389\n2214\n1943\n2510\n2544\n1330\n6275\n1492\n5837\n1830\n4440\n\n5041\n\n40092\n\n34451\n\n14820\n10096\n24218\n\n2095\n3608\n1467\n6098\n9586\n4062\n6745\n1217\n2074\n\n5660\n7032\n7666\n2711\n3050\n2260\n6274\n4672\n1028" +
        "\n6916\n7861\n\n37401\n29831\n\n15255\n6714\n2378\n13864\n\n7618\n15264\n8496\n7847\n8750\n\n6392\n4892\n1200\n2133\n2879\n6033\n5634\n1979\n5066\n3965\n4734\n1761\n5627\n2369\n\n19691\n16626\n6806\n\n3594\n1824\n4264\n5058\n2286\n6836\n4687" +
        "\n4016\n2660\n7224\n6390\n\n6213\n6396\n5387\n5318\n3022\n5080\n6098\n3699\n2437\n6430\n6091\n1255\n2480\n2490\n\n8795\n3287\n14228\n10078\n\n6720\n3431\n\n13856\n2609\n\n1683\n1241\n5941\n8021\n11838\n\n3961\n3033\n4069\n3200\n2598\n3133\n" +
        "6007\n2048\n2850\n2605\n5111\n3726\n1994\n1910\n2289\n\n11960\n3800\n11919\n3808\n12138\n7118\n\n60979\n\n10777\n8860\n3736\n3591\n12500\n8963\n\n3474\n3027\n5923\n1874\n3555\n5312\n5568\n1796\n2831\n3105\n3501\n4378\n5999\n4528\n5948" +
        "\n\n2493\n13969\n\n6992\n14112\n3430\n14233\n13381\n\n17059\n5737\n1290\n12844\n\n6302\n4418\n2067\n5059\n2085\n3061\n4411\n5662\n4097\n3333\n2182\n1090\n4185\n\n4811\n1351\n6050\n7344\n2745\n6588\n3506\n2056\n4229\n4256\n1853\n5912\n\n9673" +
        "\n2207\n4646\n2680\n12985\n3873\n\n1110\n6118\n4411\n6331\n1668\n6023\n6977\n5049\n6669\n4421\n5027\n3131\n\n9968\n2987\n5041\n18431\n\n7436\n5660\n15858\n7130\n12737\n\n5232\n9051\n10275\n9404\n3384\n5719\n5724\n10218\n\n4350\n2456\n7892" +
        "\n1318\n6932\n7890\n9595\n4605\n7672\n\n2666\n9981\n1959\n5686\n3655\n2763\n6737\n8621\n\n9915\n5955\n10523\n3976\n4166\n9602\n2985\n6160\n\n25160\n18830\n7409\n\n1322\n1283\n3839\n3054\n5782\n4615\n2579\n3332\n3046\n3634\n2428\n1373\n5638" +
        "\n\n13941\n\n2653\n14138\n2355\n12340\n6598\n\n4857\n9417\n13144\n9072\n4174\n\n1946\n6030\n5875\n1649\n1757\n2198\n2673\n3743\n1357\n1134\n1602\n\n2791\n10432\n4037\n2767\n11295\n11255\n9762\n\n9232\n11015\n21925\n\n6365\n1170\n4253\n5122" +
        "\n5390\n7061\n7781\n4584\n6362\n6367\n5321\n\n23166\n21313\n16147\n\n7915\n10734\n6921\n4796\n6442\n3520\n4416\n5702\n\n31627\n21575\n\n9569\n2837\n3816\n5052\n9399\n6174\n3291\n2513\n2932\n\n6255\n14356\n5389\n18970\n\n26896\n3552\n\n19037" +
        "\n5180\n6855\n\n4929\n5212\n15135\n\n1114\n1338\n8702\n7914\n6690\n5981\n6129\n4246\n4660\n\n2696\n4528\n4053\n5982\n2308\n6097\n1933\n6410\n4851\n4526\n5705\n5510\n3951\n\n4693\n4906\n4570\n1161\n2974\n4099\n5423\n4146\n3305\n3057\n2079" +
        "\n6187\n3196\n2285\n\n6300\n6253\n5892\n3636\n5373\n5345\n1990\n7456\n1218\n4220\n3845\n\n3028\n1790\n2104\n6750\n2516\n2482\n2574\n6806\n1613\n2279\n5389\n3979\n6672\n\n48619\n\n15159\n1029\n\n13352\n5081\n\n6292\n6989\n5568\n6181\n2773" +
        "\n4529\n3205\n1134\n6416\n5199\n2830\n4813\n\n4718\n5530\n5036\n2874\n2658\n2353\n5402\n3476\n1924\n3147\n2883\n6331\n\n14524\n30079\n\n4071\n4399\n3021\n5165\n2110\n6084\n1863\n3614\n4336\n5688\n1960\n\n25783\n28718\n\n13615\n1645\n11870" +
        "\n8796\n\n5951\n6447\n2501\n7770\n2999\n6715\n8707\n5124\n6215\n3113\n\n6241\n2189\n1752\n1812\n2727\n5703\n2710\n6113\n1732\n6237\n\n7990\n6499\n8481\n3443\n9375\n10439\n5892\n2758\n\n7919\n8753\n5124\n6388\n8026\n7326\n4457\n4352\n5781" +
        "\n5549\n\n49501\n\n10500\n23249\n\n8352\n9128\n4905\n5833\n1218\n2859\n11489\n\n6104\n6546\n6243\n6716\n3511\n3433\n4327\n2453\n2887\n5007\n4404\n4506\n2315\n\n7269\n3193\n3535\n2566\n2745\n6483\n3880\n5042\n6931\n4519\n3442\n6667\n\n16325" +
        "\n7397\n21391\n\n12648\n9268\n8280\n1497\n13788\n3384\n\n1373\n2171\n2065\n5461\n4854\n2427\n5814\n2197\n4077\n5138\n6861\n6083\n1995\n\n4817\n3501\n1937\n4840\n4299\n6083\n1330\n2737\n5361\n5941\n2762\n3191\n5530\n3913\n4139\n\n10082\n7801" +
        "\n5221\n4785\n6847\n4672\n8824\n4507\n\n25999\n21078\n\n34976\n27760\n\n6972\n2714\n1051\n4905\n1102\n6332\n6113\n4218\n7125\n4372\n4669\n\n3986\n10129\n16175\n6193\n11015\n\n6260\n5523\n2032\n5304\n5167\n2908\n6518\n5491\n1718\n6229\n3264" +
        "\n4899\n2873\n\n6613\n4234\n6130\n1017\n7986\n7727\n3564\n8250\n\n12031\n11879\n11614\n13472\n8471\n7369\n\n4315\n1636\n6292\n6768\n3788\n4643\n6397\n7402\n1379\n3518\n6438\n6196\n\n5667\n7559\n13899\n18285\n\n5266\n34337\n\n29305\n22273\n\n" +
        "9371\n5132\n1652\n2573\n8840\n8636\n4700\n3145\n7728\n\n5864\n4845\n3567\n1247\n3070\n1378\n2836\n5574\n2398\n5191\n3520\n1395\n4933\n5530\n2656\n\n5504\n5002\n4944\n4903\n3186\n1446\n3886\n1506\n2669\n5362\n2456\n2150\n4468\n5212\n2319\n\n" +
        "1543\n1581\n4295\n5685\n1977\n4361\n2381\n5288\n5557\n3159\n4833\n5577\n5892\n\n8109\n4061\n\n7132\n2394\n9579\n7360\n9023\n8589\n5666\n3108\n\n25582\n3178\n2616\n\n5742\n2967\n2577\n2141\n6022\n1148\n1971\n1779\n5039\n5210\n1043\n1633\n2697" +
        "\n\n5024\n1439\n3535\n4723\n3271\n3904\n4303\n2706\n2878\n2882\n4417\n5580\n2685\n5028\n2243\n\n4788\n2903\n6717\n5514\n4434\n6396\n3370\n2964\n6940\n3018\n1328\n6527\n4651\n\n5796\n7350\n15943\n7116\n11040\n\n9110\n1795\n10997\n9811\n5571\n" +
        "8786\n8690\n\n1173\n4256\n2326\n2947\n3133\n4930\n1653\n4548\n3971\n4837\n4084\n3362\n4144\n4015\n2631\n\n22258\n\n1270\n8084\n3413\n1180\n7841\n3467\n1068\n3763\n7479\n2988\n5377\n\n4833\n2453\n2985\n5365\n1128\n2411\n2103\n\n29169\n\n9451" +
        "\n5237\n3547\n13513\n3528\n4937\n\n14834\n6011\n11685\n17950\n\n3040\n4721\n1809\n5755\n2326\n4373\n1018\n1433\n3180\n3173\n1313\n4158\n1867\n3349\n5629\n\n4201\n12336\n18265\n14378\n\n5248\n2091\n6755\n4523\n6049\n1183\n3834\n1242\n6517\n" +
        "1561\n6666\n5117\n5600\n\n2907\n1482\n2765\n8934\n1654\n3786\n8807\n8924\n\n6131\n4724\n4774\n1030\n6359\n4452\n5557\n1501\n5743\n2434\n1809\n4657\n5609\n4773\n\n24218\n26128\n\n11710\n8138\n7143\n7236\n11903\n4547\n2419\n\n1474\n13551\n" +
        "6009\n12136\n13007\n9816\n\n7230\n3816\n5352\n5591\n\n7237\n5129\n2630\n3158\n4131\n1324\n2439\n2828\n1922\n6051\n3871\n3577\n\n21875\n13945\n15782\n\n10156\n15069\n18789\n6685\n\n6292\n12221\n17527\n\n11396\n11684\n2362\n12055\n6888\n" +
        "9393\n11909\n\n37154\n17860\n\n22974\n\n3693\n2551\n3077\n7444\n8973\n5966\n2728\n\n2554\n3119\n2796\n1993\n3959\n4421\n2691\n3002\n4104\n5876\n2748\n3633\n3567\n2280\n3852\n\n9583\n4003\n\n3100\n4338\n6077\n4813\n3223\n2373\n1607\n7412\n7798" +
        "\n7684\n\n4354\n3140\n2957\n5563\n6119\n2571\n1742\n3603\n5854\n3755\n2827\n\n1302\n4160\n1944\n1215\n1603\n5361\n5959\n3698\n5329\n3118\n4941\n1624\n4755\n3249\n5205\n\n4707\n3243\n6299\n3689\n8496\n8594\n4187\n\n5986\n4431\n1006\n1707\n1202" +
        "\n4184\n3438\n5148\n4472\n6561\n5882\n5693\n\n11346\n8748\n12659\n\n2456\n2147\n1401\n5715\n5128\n5560\n1635\n3947\n5021\n4850\n1414\n2316\n5949\n4779\n2867\n\n2530\n3901\n7034\n4665\n7109\n2416\n5461\n8825\n\n5287\n4195\n9609\n5697\n3135\n" +
        "6638\n2780\n6876\n6032\n\n17278\n18581\n4060\n13610\n\n14199\n19618\n4500\n\n4423\n15765\n6614\n11352\n1941\n\n30048\n17442\n\n6881\n8630\n10121\n9792\n6340\n8848\n7245\n7764\n\n5138\n9396\n2975\n5036\n6776\n7205\n8991\n3595\n4894\n\n1065\n" +
        "4272\n2155\n2655\n9405\n10274\n8344\n\n8234\n3276\n1914\n11975\n8096\n\n7358\n13681\n13640\n1543\n13683\n\n24588\n22649\n\n5034\n2818\n4103\n2328\n2311\n4241\n6145\n2694\n5191\n4266\n6477\n6412\n4566\n3077\n\n4442\n2199\n7109\n6674\n5257\n" +
        "4611\n\n2544\n1810\n1941\n3389\n3473\n1813\n1232\n3782\n1733\n4191\n3953\n3793\n4832\n2560\n1321\n\n3331\n2853\n5284\n1989\n4543\n4447\n5852\n2847\n3260\n5583\n5429\n2967\n3563\n1925\n2799\n\n9448\n3662\n6703\n7356\n1600\n\n4050\n6662\n7169\n" +
        "2836\n2231\n1149\n5204\n4275\n6231\n7478\n1388\n6980\n\n2185\n1526\n1640\n9156\n6623\n8572\n7426\n9419\n\n10637\n9584\n8293\n7473\n3529\n7532\n\n3987\n12127\n10749\n3399\n11041\n4600\n9896\n\n3728\n1878\n5192\n3264\n6367\n4429\n6449\n7005\n" +
        "4883\n5359\n2112\n6228\n\n13574\n6574\n11518\n11909\n13625\n\n16357\n19546\n7520\n8254\n\n2122\n1712\n2729\n2847\n1157\n2895\n4850\n2805\n5603\n2321\n6113\n5468\n1230\n2385\n\n3947\n3326\n2395\n5776\n4035\n3206\n5845\n6429\n5039\n4540\n5047\n" +
        "4237\n6953\n\n1738\n8822\n11967\n10160\n4327\n8382\n2686\n\n2778\n6909\n7649\n2787\n8749\n1720\n6863\n5515\n8631\n3257\n\n1369\n2470\n2726\n7415\n5232\n1919\n2981\n4437\n3168\n6412\n7072\n3201\n\n19275\n10942\n\n12930\n12593\n9356\n5680\n10193" +
        "\n4399\n\n11119\n10651\n8687\n12028\n1713\n8311\n10089\n\n3752\n\n10177\n9060\n4817\n3564\n7272\n10452\n\n1563\n3885\n3191\n6312\n5524\n5207\n3669\n\n8105\n7217\n4719\n9214\n3973\n10782\n10563\n\n10142\n4264\n\n7283\n\n15973\n9578\n9884\n4478" +
        "\n10540\n\n5548\n4654\n3024\n2243\n3985\n1220\n3461\n1042\n1845\n2888\n3931\n2356\n1430\n3373\n4604\n\n8036\n3016\n3510\n2659\n8700\n1539\n1202\n2116\n4351\n7388\n\n2995\n7003\n8022\n2012\n1976\n3938\n3744\n6146\n5056\n7590\n4008\n\n4459\n" +
        "12305\n7633\n2742\n12867\n12607\n\n3791\n5059\n6361\n3008\n4543\n1374\n6821\n5967\n8461\n4241\n\n1641\n1364\n2037\n2479\n1413\n4250\n5042\n2438\n2855\n3081\n3535\n3966\n3574\n1149\n3606\n\n3397\n2787\n5638\n2321\n3765\n5617\n4870\n4456\n6681" +
        "\n1890\n1068\n3609\n3043\n\n3436\n4011\n5212\n5576\n4139\n1387\n6298\n4179\n4000\n4207\n3302\n1539\n2793\n3551\n";

            string[] elves = calorieCounter.Split("\n\n", StringSplitOptions.None);
            int firstElf = 0, secondElf = 0, thirdElf = 0;
            foreach (var elf in elves)
            {
                string[] tmp = elf.Split("\n", StringSplitOptions.None);
                int totalCalories = 0;
                foreach (string s in tmp)
                {
                    int calorieCheck = 0;
                    if (!s.Equals(""))
                        calorieCheck = Int32.Parse(s);
                    totalCalories += calorieCheck;
                }
                if (totalCalories > firstElf)
                {
                    if (firstElf > secondElf)
                        secondElf = firstElf;
                    else if (firstElf > thirdElf)
                        thirdElf = firstElf;
                    firstElf = totalCalories;
                }
                else if (totalCalories > secondElf)
                {
                    if (secondElf > thirdElf)
                        thirdElf = secondElf;
                    secondElf = totalCalories;
                }
                else if (totalCalories > thirdElf)
                    thirdElf = totalCalories;

            }
            Console.WriteLine($"The elf with the most calories has {firstElf} calories.");
            Console.WriteLine($"The highest calories combined is {firstElf + secondElf + thirdElf}.");
            Console.ReadKey();
        }
    }
   
}
