<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/equipmentrepair/EquipmentRepair.js此处编写
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
    import extend from "@/extension/business/equipmentrepair/EquipmentRepair.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '维修记录',
                name: 'equipmentrepair/EquipmentRepair',
                url: "/EquipmentRepair/",
                sortName: "ID"
            });
            const editFormFields = ref({"EquipmentNo":"","AlarmCode":"","AlarmDescription":"","RepairTime":"","RepairDescription":""});
            const editFormOptions = ref([[{"dataKey":"设备编号","data":[],"title":"设备编号","field":"EquipmentNo","type":"select"}],
                              [{"dataKey":"设备报警代码","data":[],"title":"故障代码","field":"AlarmCode","type":"select"}],
                              [{"title":"故障描述","field":"AlarmDescription","type":"textarea"}],
                              [{"title":"维修时间","field":"RepairTime","type":"datetime"}],
                              [{"title":"维修描述","field":"RepairDescription","type":"textarea"}]]);
            const searchFormFields = ref({"EquipmentNo":"","AlarmCode":""});
            const searchFormOptions = ref([[{"dataKey":"设备编号","data":[],"title":"设备编号","field":"EquipmentNo","type":"like"},{"dataKey":"设备报警代码","data":[],"title":"故障代码","field":"AlarmCode","type":"select"}]]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:110,hidden:true,require:true,align:'left'},
                       {field:'EquipmentNo',title:'设备编号',type:'string',bind:{ key:'设备编号',data:[]},width:110,align:'left',sort:true},
                       {field:'AlarmCode',title:'故障代码',type:'string',bind:{ key:'设备报警代码',data:[]},width:110,align:'left'},
                       {field:'AlarmDescription',title:'故障描述',type:'string',width:120,align:'left'},
                       {field:'CreateOperator',title:'录入人员',type:'string',width:110,align:'left'},
                       {field:'CreateTime',title:'录入时间',type:'datetime',width:110,align:'left',sort:true},
                       {field:'RepairOperator',title:'维修人员',type:'string',width:110,align:'left'},
                       {field:'RepairTime',title:'维修时间',type:'datetime',width:110,align:'left',sort:true},
                       {field:'RepairDescription',title:'维修描述',type:'string',width:180,align:'left'}]);
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
