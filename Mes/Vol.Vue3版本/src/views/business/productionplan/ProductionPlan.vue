<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/productionplan/ProductionPlan.js此处编写
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
    import extend from "@/extension/business/productionplan/ProductionPlan.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '生产计划',
                name: 'productionplan/ProductionPlan',
                url: "/ProductionPlan/",
                sortName: "ID"
            });
            const editFormFields = ref({"PlanNo":"","PlanSN":"","ProductType":"","FormulaCode":"","Status":""});
            const editFormOptions = ref([[{"title":"计划号","field":"PlanNo"},
                               {"title":"批次号","field":"PlanSN"}],
                              [{"dataKey":"产品下拉","data":[],"title":"产品型号","field":"ProductType","type":"select"},
                               {"title":"配方编号","field":"FormulaCode"}],
                              [{"dataKey":"计划状态","data":[],"title":"状态","field":"Status","type":"select"}]]);
            const searchFormFields = ref({"PlanNo":"","Status":""});
            const searchFormOptions = ref([[{"title":"计划号","field":"PlanNo","type":"like"},{"dataKey":"计划状态","data":[],"title":"状态","field":"Status","type":"select"}]]);
            const columns = ref([{field:'PlanNo',title:'计划号',type:'string',width:110,align:'left',sort:true},
                       {field:'PlanSN',title:'批次号',type:'string',width:110,align:'left'},
                       {field:'ProductNo',title:'产品编号',type:'string',width:110,align:'left'},
                       {field:'ProductType',title:'产品型号',type:'string',bind:{ key:'产品下拉',data:[]},width:110,align:'left'},
                       {field:'FormulaCode',title:'配方编号',type:'string',width:110,align:'left'},
                       {field:'Status',title:'状态',type:'string',bind:{ key:'计划状态',data:[]},width:110,align:'left'},
                       {field:'PlanQty',title:'计划生产数量',type:'int',width:80,align:'left'},
                       {field:'PlanStartTime',title:'计划上时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'PlanEndTime',title:'计划下线时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'PlanCreateTime',title:'计划创建日期',type:'datetime',width:150,align:'left',sort:true},
                       {field:'ID',title:'1',type:'int',sort:true,width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Spare3',title:'Spare3',type:'string',width:110,hidden:true,align:'left'},
                       {field:'Spare2',title:'Spare2',type:'string',width:110,hidden:true,align:'left'},
                       {field:'Spare1',title:'Spare1',type:'string',width:110,hidden:true,align:'left'},
                       {field:'OrderSoure',title:'数据来源',type:'string',width:110,align:'left'},
                       {field:'PlanStion',title:'计划当前工位',type:'string',width:110,align:'left'},
                       {field:'LineName',title:'计划当前线体',type:'string',width:110,align:'left'},
                       {field:'Seq',title:'流水号',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Spare4',title:'Spare4',type:'string',width:110,hidden:true,align:'left'},
                       {field:'Spare5',title:'Spare5',type:'string',width:110,hidden:true,align:'left'},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'最后一次修改人',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'最后一次修改时间',type:'datetime',width:150,align:'left',sort:true}]);
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
