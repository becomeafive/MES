<template>
  <div class="home-contianer">
    <div class="h-top">
      <div class="h-top-center" id="h-chart1">left</div>
      <div class="h-top-right task-table">
        <h3 class="h3" style="text-align: center; font-weight: bold;" >软件功能说明</h3>
        <table border="0" cellspacing="0" cellpadding="0">
          <tr v-for="(row, index) in list" :key="index">
            <td>{{ index + 1 }}</td>
            <td>{{ row.desc }}</td>
          </tr>
        </table>
      </div>
    </div>
  </div>
</template>
<script>
import * as echarts from 'echarts';
import { chart1, chart2, chart3, chart4 } from './home/home-chart-options';
import { ref, onMounted, onUnmounted } from 'vue';
var $chart2;
export default {
  components: {},
  data() {
    return {
      n: 90,
      value1: '1',
      applicants: {
        //报名信息
        day: 20, //本日
        week: 150, //本周
        month: 1200, //本月
        totalBoy: 800,
        totalGirl: 890,
        taotal: 1690
      }, //报名信息
      list: [
        { desc: '登录功能：进入系统需要进行登录。' },
        { desc: '用户管理：对登录进行管控。' },
        { desc: '角色管理：对用户进行管控，可自行设置用户可见页面。' },
        { desc: '权限管理：对角色进行管控，设置各角色权限。' },
        { desc: '车型配置：设置现有主、子车型。' },
        {desc: '车型螺栓配置：设置各车型对应的螺栓。'},
        {desc: '其他功能待开发......'}
      ],
    };
  },
  setup() {
    let open = (item) => {
      window.open(item.url, '_blank');
    };
    let interval;
    onMounted(() => {
      $chart = echarts.init(document.getElementById('h-chart1'));
      $chart.setOption(chart1);
    });
    onUnmounted(() => {
      interval && clearInterval(interval);
      if ($chart) {
        $chart.dispose();
      }
    });
    return { open };
  },
  destroyed() {
    $chart2 = null;
  }
};
var $chart, $chart2, $chart3;
// window.addEventListener("resize", function () {
//   $chart2.setOption(chart2);
// });
</script>
<style lang="less" scoped>
.home-contianer {
  padding: 6px;
  background: #eee;
  width: 100%;
  height: 100%;
  // max-width: 800px;
  // position: absolute;
  top: 0;
  right: 0;
  left: 0;
  margin: 0 auto;

  .h-top {
    display: flex;
    .h-top-left {
      height: 100%;
      width: 300px;
      background: white;
    }
    height: 800px;
  }
  .h-top > div {
    border: 1px solid #e8e7e7;
    border-radius: 5px;
    // margin: 6px;
  }
  .h-top-center {
    height: 100%;
    background: white;
    margin: 0 6px;
    display: flex;
    flex-direction: column;
    flex: 1;
    .item1 .num {
      padding-top: 28px;
    }
    .item2 .num {
      padding-bottom: 20px;
    }

    .n-item {
      width: 100%;
      height: 100%;
      text-align: center;
      cursor: pointer;
      // display: flex;
      .item {
        border-right: 1px solid #e5e5e5;
        width: 33.3333333%;
        float: left;
        height: 50%;
        border-bottom: 1px solid #e5e5e5;
        padding: 47px 0;
        font-size: 13px;
      }
      .item:hover {
        background: #f9f9f9;
        cursor: pointer;
      }
      .item:last-child {
        border-right: 0;
      }
      .item3,
      .item6 {
        border-right: 0;
      }
      .num {
        word-break: break-all;
        color: #282727;
        font-size: 30px;
        transition: transform 0.8s;
      }
      .num:hover {
        color: #55ce80;
        transform: scale(1.2);
      }
      .text {
        font-size: 13px;
        color: #777;
      }
    }
  }
  .h-top-right {
    // flex: 1;

    width: 400px;
    height: 100%;
    background: white;
  }
  .h3 {
    padding: 7px 15px;
    font-weight: 500;
    background: #fff;
    border-bottom: 1px dotted #d4d4d4;
  }
}
.task-table {
  table {
    width: 100%;
    .thead {
      font-weight: bold;
    }
    tr {
      cursor: pointer;
      td {
        border-bottom: 1px solid #f3f3f3;
        padding: 9px 8px;
        font-size: 12px;
      }
    }
    tr:hover {
      background: #eee;
    }
  }
}
.h-chart {
  height: 340px;
  margin: 6px 0px;
  display: flex;
  .h-left-grid {
    width: 300px;
    height: 100%;
    background: white;
    display: inline-block;
    .name {
      margin-left: 7px;
    }
    .item:hover {
      background: #f9f9f9;
      cursor: pointer;
    }
    .item {
      padding: 22px 14px;
      float: left;
      width: 50%;
      height: 33.33333%;
      border-bottom: 1px solid #eee;
      border-right: 1px solid #eee;
      i {
        font-size: 30px;
      }
      .desc {
        font-size: 12px;
        color: #c3c3c3;
        padding: 5px 0 0 4px;
        line-height: 1.5;
      }
    }
  }
}
#h-chart2 {
  border-radius: 3px;
  background: white;
  padding-top: 10px;
  height: 100%;
  width: 0;
  flex: 1;
  margin: 0 7px;
}
#h-chart3 {
  border-radius: 3px;
  padding: 10px 10px 0 10px;
  background: white;
  // padding-top: 10px;
  height: 100%;

  width: 400px;
}
</style>
