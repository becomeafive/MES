<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/Sys_Role.js此处编写
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
    import extend from "@/extension/system/Sys_Role.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Role_Id',
                footer: "Foots",
                cnName: '角色管理',
                name: 'Sys_Role',
                url: "/Sys_Role/",
                sortName: "Role_Id"
            });
            const editFormFields = ref({"ParentId":"","RoleName":"","Enable":""});
            const editFormOptions = ref([[{"title":"父级ID","required":true,"field":"ParentId","type":"number"},
                               {"title":"角色名称","required":true,"field":"RoleName"}],
                              [{"dataKey":"enable","data":[],"title":"是否启用","field":"Enable","type":"switch"}]]);
            const searchFormFields = ref({"RoleName":"","CreateDate":"","ModifyDate":""});
            const searchFormOptions = ref([[{"title":"角色名称","field":"RoleName","type":"like"}],[{"title":"创建时间","field":"CreateDate","type":"datetime"},{"title":"修改时间","field":"ModifyDate","type":"datetime"}]]);
            const columns = ref([{field:'Role_Id',title:'角色ID',type:'int',width:70,readonly:true,require:true,align:'left',sort:true},
                       {field:'ParentId',title:'父级ID',type:'int',width:70,require:true,align:'left'},
                       {field:'RoleName',title:'角色名称',type:'string',link:true,width:90,require:true,align:'left'},
                       {field:'Dept_Id',title:'部门ID',type:'int',width:90,hidden:true,align:'left'},
                       {field:'DeptName',title:'部门名称',type:'string',width:90,hidden:true,align:'left'},
                       {field:'Enable',title:'是否启用',type:'byte',bind:{ key:'enable',data:[]},width:90,hidden:true,align:'left'},
                       {field:'OrderNo',title:'排序',type:'int',width:90,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,readonly:true,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:90,readonly:true,align:'left',sort:true},
                       {field:'Modifier',title:'修改人',type:'string',width:130,readonly:true,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',width:90,readonly:true,align:'left',sort:true}]);
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
