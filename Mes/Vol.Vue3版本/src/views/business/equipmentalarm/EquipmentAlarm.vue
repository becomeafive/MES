<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/equipmentalarm/EquipmentAlarm.js此处编写
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
    import extend from "@/extension/business/equipmentalarm/EquipmentAlarm.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '故障代码',
                name: 'equipmentalarm/EquipmentAlarm',
                url: "/EquipmentAlarm/",
                sortName: "ID"
            });
            const editFormFields = ref({"AlarmType":"","AlarmCode":"","AlarmDescription":"","LineID":"","StationID":""});
            const editFormOptions = ref([[{"dataKey":"故障类型","data":[],"title":"故障类型","field":"AlarmType","type":"select"},
                               {"title":"故障代码","field":"AlarmCode"}],
                              [{"title":"故障描述","field":"AlarmDescription","type":"textarea"}],
                              [{"dataKey":"线体下拉","data":[],"title":"所属线体","field":"LineID","type":"select"},
                               {"dataKey":"工位下拉","data":[],"title":"所属工位","field":"StationID","type":"select"}]]);
            const searchFormFields = ref({"AlarmType":"","AlarmCode":""});
            const searchFormOptions = ref([[{"dataKey":"故障类型","data":[],"title":"故障类型","field":"AlarmType","type":"select"},{"title":"故障代码","field":"AlarmCode","type":"like"}]]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:110,hidden:true,require:true,align:'left'},
                       {field:'AlarmType',title:'故障类型',type:'string',bind:{ key:'故障类型',data:[]},width:110,align:'left',sort:true},
                       {field:'AlarmCode',title:'故障代码',type:'string',width:110,align:'left'},
                       {field:'AlarmDescription',title:'故障描述',type:'string',width:120,align:'left'},
                       {field:'LineID',title:'所属线体',type:'int',bind:{ key:'线体下拉',data:[]},width:80,align:'left'},
                       {field:'StationID',title:'所属工位',type:'int',bind:{ key:'工位下拉',data:[]},width:80,align:'left'}]);
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
