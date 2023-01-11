<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/productline/ProductLine.js此处编写
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
    import extend from "@/extension/business/productline/ProductLine.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '线体管理',
                name: 'productline/ProductLine',
                url: "/ProductLine/",
                sortName: "ID"
            });
            const editFormFields = ref({"LineName":"","LineDecription":""});
            const editFormOptions = ref([[{"title":"线体编号","field":"LineName","colSize":5}],
                              [{"title":"线体描述","field":"LineDecription","colSize":10,"type":"textarea"}]]);
            const searchFormFields = ref({"LineName":"","LineStatus":""});
            const searchFormOptions = ref([[{"dataKey":"线体状态","data":[],"title":"线体状态","field":"LineStatus","type":"select"},{"title":"线体编号","field":"LineName","type":"like"}]]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:110,hidden:true,require:true,align:'left'},
                       {field:'LineName',title:'线体编号',type:'string',width:110,align:'left',sort:true},
                       {field:'LineDecription',title:'线体描述',type:'string',width:110,align:'left'},
                       {field:'LineStatus',title:'线体状态',type:'string',bind:{ key:'线体状态',data:[]},width:110,readonly:true,align:'left'},
                       {field:'OperatorName',title:'操作人',type:'string',width:110,readonly:true,align:'left'},
                       {field:'UpTime',title:'操作时间',type:'datetime',width:150,readonly:true,align:'left',sort:true}]);
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
