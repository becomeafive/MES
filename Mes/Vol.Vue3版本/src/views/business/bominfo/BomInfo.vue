<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/bominfo/BomInfo.js此处编写
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
    import extend from "@/extension/business/bominfo/BomInfo.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: 'Bom清单',
                name: 'bominfo/BomInfo',
                url: "/BomInfo/",
                sortName: "ID"
            });
            const editFormFields = ref({"ProductID":"","MaterialName":"","MaterialSN":"","MaterialDescription":"","MaterialsNO1":"","MaterialsNO2":"","MaterialsNO3":"","MaterialsNO4":""});
            const editFormOptions = ref([[{"dataKey":"产品下拉","data":[],"title":"产品型号","field":"ProductID","type":"select"}],
                              [{"title":"物料名称","field":"MaterialName"},
                               {"title":"物料批次","field":"MaterialSN"}],
                              [{"title":"物料描述","field":"MaterialDescription","colSize":12,"type":"textarea"}],
                              [{"title":"物料识别码1","field":"MaterialsNO1"},
                               {"title":"物料识别码2","field":"MaterialsNO2"}],
                              [{"title":"物料识别码3","field":"MaterialsNO3"},
                               {"title":"物料识别码4","field":"MaterialsNO4"}]]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ProductID',title:'产品型号',type:'int',bind:{ key:'产品下拉',data:[]},width:110,align:'left',sort:true},
                       {field:'MaterialName',title:'物料名称',type:'string',width:180,align:'left'},
                       {field:'MaterialSN',title:'物料批次',type:'string ',width:110,align:'left'},
                       {field:'MaterialDescription',title:'物料描述',type:'string',width:220,align:'left'},
                       {field:'MaterialsNO1',title:'物料识别码1',type:'string',width:180,align:'left'},
                       {field:'MaterialsNO2',title:'物料识别码2',type:'string ',width:110,align:'left'},
                       {field:'MaterialsNO3',title:'物料识别码3',type:'string ',width:110,align:'left'},
                       {field:'MaterialsNO4',title:'物料识别码4',type:'string ',width:110,align:'left'},
                       {field:'CreateTime',title:'创建日期',type:'datetime',width:110,align:'left',sort:true}]);
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
