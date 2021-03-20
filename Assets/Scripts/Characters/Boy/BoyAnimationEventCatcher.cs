using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class BoyAnimationEventCatcher : MonoBehaviour
{
    private BoyController _boy;

    private void Start()
    {
        _boy = GetComponent<BoyController>();
    }

    void TakeChocolateEnd()
    {
        _boy.SetState(BoyState.OnStopTakeScum);
    }

    void TakeScumEnd()
    {
        _boy.SetState(BoyState.OnStopTakeScum);
    }
}
