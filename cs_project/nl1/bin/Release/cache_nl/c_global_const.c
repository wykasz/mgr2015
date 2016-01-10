
/* (c) Atinea Sp z o. o.
 *  Stamp: nianio lang
 */
#include "c_global_const.h"

static ImmT  ___global_const__ = NULL;
static int ___global_const_init__ = 1;
static int ___global_const_offset;
void ___global_const_init(){
if(___global_const_init__) {
___global_const_init__ = 0;
___global_const_offset = c_rt_lib0get_global_const_offset();
___global_const__ = alloc_mem(0 * ___global_const_offset);


c_rt_lib0register_global_const((ImmT )___global_const__,(ImmT )___global_const__ + 0 * ___global_const_offset);
}}
ImmT ___get_global_const(int __nr) {
ImmT ret = NULL;
c_rt_lib0copy(&ret, (ImmT )___global_const__ + ___global_const_offset * __nr);
return ret;
}
