<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/operationguidance/OperationGuidance.js此处编写
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
    import extend from "@/extension/business/operationguidance/OperationGuidance.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '维修指南',
                name: 'operationguidance/OperationGuidance',
                url: "/OperationGuidance/",
                sortName: "ID"
            });
            const editFormFields = ref({"FileName":"","Path":""});
            const editFormOptions = ref([[{"title":"操作文档","required":true,"field":"FileName","type":"text"}],
                              [{"title":"文件","required":true,"field":"Path"}]]);
            const searchFormFields = ref({"FileName":""});
            const searchFormOptions = ref([[{"title":"操作文档","field":"FileName","type":"like"}]]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:110,hidden:true,require:true,align:'left'},
                       {field:'FileName',title:'操作文档',type:'string',sort:true,width:110,require:true,align:'left',sort:true},
                       {field:'Path',title:'文件',type:'file',sort:true,width:220,hidden:true,require:true,align:'left'},
                       {field:'Creator',title:'操作人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'操作时间',type:'datetime',width:110,align:'left',sort:true}]);
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
