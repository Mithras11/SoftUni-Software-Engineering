namespace P04.Recharge.Models
{
    using Contracts;

    public class RechargeStation
    {
        public void Recharge(IRechargeable rechargeable)
        {
            rechargeable.Recharge();
        }
    }
}

