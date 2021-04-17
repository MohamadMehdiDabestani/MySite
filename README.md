const Country = [
  {
    label: "USD",
    data: [0.25, 0.7, 1, 0.1],
    borderColor: "#fd0000",
    fill: false,
    cubicInterpolationMode: "monotone",
    tension: 0.4,
  },
  {
    label: "EUR",
    data: [0, 1, 0.2, 0.4],
    borderColor: "#fd8700",
    fill: false,
    tension: 0.4,
  },
  {
    label: "GBP",
    data: [0.1, 0.2, 1, 0.7],
    borderColor: "#fdec00",
    fill: false,
  },
  {
    label: "JPY",
    data: [-0.1, 0.4, 1, 0.7],
    borderColor: "#9cfd00",
    fill: false,
  },
  {
    label: "NZD",
    data: [0.25, 0.74, 0.6, 0.8],
    borderColor: "#00fd00",
    fill: false,
  },
  {
    label: "AUD",
    data: [0.1, 0.2, 0.7, 1],
    borderColor: "#00fdbe",
    fill: false,
  },
  {
    label: "CHF",
    data: [-0.75, 0.2, 0.8, 1.2],
    borderColor: "#00cafd",
    fill: false,
  },
  {
    label: "CAD",
    data: [0.25, 0.8, 1, 1.7],
    borderColor: "#0076fd",
    fill: false,
  },
  {
    label: "TRY",
    data: [19, 18, 15, 19],
    borderColor: "#51a2ff",
    fill: false,
  },
  {
    label: "MXN",
    data: [4, 3, 5, 7],
    borderColor: "#033d80",
    fill: false,
  },
  {
    label: "ZAR",
    data: [3.5, 3.7, 2.8, 3.4],
    borderColor: "#4c6a8d",
    fill: false,
  },
  {
    label: "SEK",
    data: [0, -0.1, -0.5, 0.7],
    borderColor: "#007058",
    fill: false,
  },
  {
    label: "DKK",
    data: [-0.35, 0.3, 0.4, 0.7],
    borderColor: "#43ffd6",
    fill: false,
  },
  {
    label: "PLN",
    data: [0.1, 0.7, 1, 1.5],
    borderColor: "#01550c",
    fill: false,
  },
  {
    label: "SGD",
    data: [0.26, 0.4, 0.8, 1],
    borderColor: "#79f089",
    fill: false,
  },
  {
    label: "CZK",
    data: [0.25, 0.1, 0.8, 1.2],
    borderColor: "#6e8b02",
    fill: false,
  },
  {
    label: "HKD",
    data: [0.86, 0.9, 1.2, 1.5],
    borderColor: "#ca01ca",
    fill: false,
  },
  {
    label: "HUF",
    data: [0.6, 0.8, 0.5, 1],
    borderColor: "#f36ef3",
    fill: false,
  },
  {
    label: "NOK",
    data: [0, 0.3, 0.7, 1],
    borderColor: "#f5093c",
    fill: false,
  },
  {
    label: "RUB",
    data: [4.5, 5, 5.4, 4.3],
    borderColor: "#86011e",
    fill: false,
  },
  {
    label: "THB",
    data: [0.5, 0.7, 1, 1.2],
    borderColor: "#fc5b7e",
    fill: false,
  },
  {
    label: "CHN",
    data: [3.85, 4, 4.2, 3.2],
    borderColor: "#7e0ffd",
    fill: false,
  },
  {
    label: "REAL",
    data: [2.75, 2.5, 2.9, 1.8],
    borderColor: "#3b017e",
    fill: false,
  },
];
const selectFrist = document.querySelector("#selectFirst");
const selectSecond = document.querySelector("#selectSecond");
const selectContainer = document.querySelector(".selects");
let ctx = document.getElementById("chart");
const DATA_COUNT = 34;
const labels = ['2020-5-15' , '2020-5-16' , '2020-5-17' , '2020-5-18' , '2020-5-19'];

const data = {
  labels: labels,
  datasets: [
    {
      label: "USD",
      data: [0.25, 0.7, 1, 0.1],
      borderColor: "#fd0000",
      fill: false,
      cubicInterpolationMode: "monotone",
      tension: 0.4,
    },
    {
      label: "USD",
      data: [0.25, 0.7, 1, 0.1],
      borderColor: "#fd0000",
      fill: false,
      cubicInterpolationMode: "monotone",
      tension: 0.4,
    },
  ],
};

const config = {
  type: "line",
  data: data,
  options: {
    responsive: true,
    interaction: {
      intersect: false,
    },
    scales: {
      x: {
        display: true,
        title: {
          display: true,
        },
      },
      y: {
        display: true,
        title: {
          display: true,
          text: "Value",
        },
        suggestedMin: -5,
        suggestedMax: 20,
      },
    },
  },
};
let chart = new Chart(ctx, {
  ...config,
});
const SetColorBox = (color, idx) => {
  selectContainer.children[idx].style.background = color;
};
const FindItem = (label) => {
  return Country.find((c) => c.label == label);
};
const Update = (item, idx) => {
  let old = chart.data.datasets[idx];
  old.label = item.label;
  old.data = item.data;
  old.borderColor = item.borderColor;
  chart.update();
};

selectFrist.addEventListener("change", () => {
  const item = FindItem(selectFrist.value);
  Update(item, 0);
  SetColorBox(item.borderColor, 0);
});
selectSecond.addEventListener("change", () => {
  const item = FindItem(selectSecond.value);
  Update(item, 1);
  SetColorBox(item.borderColor, 3);
});
Country.forEach((c) => {
  let node = document.createElement("option");
  let txt = document.createTextNode(c.label);
  node.appendChild(txt);
  node.setAttribute("value", c.label);
  selectFrist.appendChild(node);
});
Country.forEach((c) => {
  let node = document.createElement("option");
  let txt = document.createTextNode(c.label);
  node.appendChild(txt);
  node.setAttribute("value", c.label);
  selectSecond.appendChild(node);
});
