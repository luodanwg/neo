﻿namespace Neo.Wallets
{
    public abstract class WalletAccount
    {
        public readonly UInt160 ScriptHash;
        public string Label;
        public bool IsDefault;
        public bool Lock;
        public VerificationContract Contract;

        public string Address => Wallet.ToAddress(ScriptHash);
        public abstract bool HasKey { get; }

        public abstract KeyPair GetKey();

        protected WalletAccount(UInt160 scriptHash)
        {
            this.ScriptHash = scriptHash;
        }
    }
}
