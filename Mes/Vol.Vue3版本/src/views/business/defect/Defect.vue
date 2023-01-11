<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/defect/Defect.js此处编写
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
    import extend from "@/extension/business/defect/Defect.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '缺陷维护',
                name: 'defect/Defect',
                url: "/Defect/",
                sortName: "ID"
            });
            const editFormFields = ref({"DefectNo":"","DefectName":"","DefectInfo":""});
            const editFormOptions = ref([[{"title":"缺陷代码","required":true,"field":"DefectNo","type":"text"},
                               {"title":"缺陷名称","required":true,"field":"DefectName","type":"text"}],
                              [{"title":"缺陷详情","field":"DefectInfo","type":"text"}]]);
            const searchFormFields = ref({"DefectName":"","DefectInfo":""});
            const searchFormOptions = ref([[{"title":"缺陷名称","field":"DefectName","type":"like"}],[{"title":"缺陷详情","field":"DefectInfo","type":"like"}]]);
            const columns = ref([{field:'DefectNo',title:'缺陷代码',type:'string',sort:true,width:110,require:true,align:'left',sort:true},
                       {field:'DefectName',title:'缺陷名称',type:'string',sort:true,width:110,require:true,align:'left'},
                       {field:'DefectInfo',title:'缺陷详情',type:'string',sort:true,width:120,align:'left'},
                       {field:'ID',title:'ID',type:'int',width:80,hidden:true,require:true,align:'left'},
                       {field:'Creator',title:'操作人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'操作时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'IsEnabled',title:'是否已有子订单，如果是1，不能删除',type:'string',width:110,hidden:true,align:'left'}]);
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
