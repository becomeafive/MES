<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/Sys_User.js此处编写
 -->
<template>
    <view-grid ref="grid"
               :columns="columns"
               :detail="detail"
               :editFormFields="editFormFields"
               :editFormOptions="editFormOptions"
               :searchFormFields="searchFormFields"
               :searchFormOptions="searchFormOptions"
               :table="table"
               :extend="extend">
    </view-grid>
</template>
<script>
    import extend from "@/extension/system/Sys_User.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'User_Id',
                footer: "Foots",
                cnName: '用户管理',
                name: 'Sys_User',
                url: "/Sys_User/",
                sortName: "User_Id"
            });
            const editFormFields = ref({"UserName":"","Gender":"","Role_Id":"","UserTrueName":"","Confirm":""});
            const editFormOptions = ref([[{"title":"帐号","required":true,"field":"UserName","disabled":true},
                               {"dataKey":"gender","data":[],"title":"性别","field":"Gender","type":"select"}],
                              [{"dataKey":"roles","data":[],"title":"角色","required":true,"field":"Role_Id","type":"select"},
                               {"title":"真实姓名","required":true,"field":"UserTrueName","type":"text"}],
                              [{"dataKey":"enable","data":[],"title":"不合格确认","field":"Confirm","type":"switch"}]]);
            const searchFormFields = ref({"UserName":"","Gender":"","Role_Id":"","UserTrueName":""});
            const searchFormOptions = ref([[{"title":"帐号","field":"UserName","type":"like"},{"dataKey":"gender","data":[],"title":"性别","field":"Gender","type":"like"}],[{"dataKey":"roles","data":[],"title":"角色","field":"Role_Id","type":"like"},{"title":"真实姓名","field":"UserTrueName","type":"like"}]]);
            const columns = ref([{field:'UserName',title:'帐号',type:'string',link:true,width:120,readonly:true,require:true,align:'left',sort:true},
                       {field:'User_Id',title:'User_Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Gender',title:'性别',type:'int',bind:{ key:'gender',data:[]},width:100,align:'left'},
                       {field:'Role_Id',title:'角色',type:'int',bind:{ key:'roles',data:[]},width:150,require:true,align:'left'},
                       {field:'RoleName',title:'RoleName',type:'string',width:90,hidden:true,require:true,align:'left'},
                       {field:'Token',title:'Token',type:'string',width:180,hidden:true,align:'left'},
                       {field:'UserTrueName',title:'真实姓名',type:'string',width:150,require:true,align:'left'},
                       {field:'CreateDate',title:'注册时间',type:'datetime',width:150,readonly:true,align:'left',sort:true},
                       {field:'CreateID',title:'CreateID',type:'int',width:90,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,readonly:true,align:'left'},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:90,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,hidden:true,readonly:true,align:'left'},
                       {field:'LastLoginDate',title:'最后登陆时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'LastModifyPwdDate',title:'最后密码修改时间',type:'datetime',width:150,hidden:true,align:'left',sort:true},
                       {field:'Remark',title:'备注',type:'string',width:180,hidden:true,align:'left'},
                       {field:'OrderNo',title:'排序号',type:'int',width:90,hidden:true,align:'left'},
                       {field:'Confirm',title:'不合格确认',type:'byte',bind:{ key:'enable',data:[]},width:110,align:'left'}]);
            const detail = ref({
                cnName: "#detailCnName",
                table: "#detailTable",
                columns: [],
                sortName: "",
                key: ""
            });
            return {
                table,
                extend,
                editFormFields,
                editFormOptions,
                searchFormFields,
                searchFormOptions,
                columns,
                detail,
            };
        },
    });
</script>
