<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/componentmaintenance/ComponentMaintenance.js此处编写
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
    import extend from "@/extension/business/componentmaintenance/ComponentMaintenance.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '部位维护',
                name: 'componentmaintenance/ComponentMaintenance',
                url: "/ComponentMaintenance/",
                sortName: "ID"
            });
            const editFormFields = ref({"ComponentName":""});
            const editFormOptions = ref([[{"title":"部件名称","required":true,"field":"ComponentName"}]]);
            const searchFormFields = ref({"ComponentName":""});
            const searchFormOptions = ref([[{"title":"部件名称","field":"ComponentName","type":"like"}]]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:110,hidden:true,require:true,align:'left'},
                       {field:'ComponentName',title:'部件名称',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'Creator',title:'操作人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'操作时间',type:'datetime',width:110,align:'left',sort:true},
                       {field:'IsEnable',title:'是否启用',type:'string',width:110,hidden:true,align:'left'}]);
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
