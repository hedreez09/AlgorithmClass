 private (string SecretKey, string Reference, string TransactionAmount, string transactionDate) GetHashDetails(String s, out string error)
        {
            error = string.Empty;
            string details = string.Empty;
            string SecretKey = string.Empty;
            string Reference = string.Empty;
            string TransactionAmount = string.Empty;
            string transactionDate = string.Empty;
            try
            {
                details = new CryptoServices().ComputeSHA512Hash(s);
                // PAN|EXPIRY|PIN|CVV
                var detailsList = details.Split('|').ToList();
                if(detailsList.Count != 4)
                {
                    error = "Invalid hash details";
                }
                else
                {
                    SecretKey = detailsList[0];
                    Reference = detailsList[1];
                    TransactionAmount = detailsList[2];
                    transactionDate = detailsList[3];
                }
            }
            catch
            {
                error = "Hash details must be  up to four";
            }

            return (SecretKey, Reference, TransactionAmount, transactionDate);
        }
