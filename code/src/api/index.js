import request from "@/utils/request";

let apiURL = {
  fetchList: "/post/list",
  fetchFocus: "/focus/list",
  fetchCategory: "/category",
  fetchFriend: "/friend",
  fetchSocial: "/social",
  fetchSiteInfo: "/site",
  fetchComment: "/comment",
};

export function fetchList(params) {
  return request({
    url: apiURL.fetchList,
    method: "get",
    params: params,
  });
}

export function fetchFocus() {
  return request({
    url: apiURL.fetchFocus,
    method: "get",
    params: {},
  });
}

export function fetchCategory() {
  return request({
    url: apiURL.fetchFocus,
    method: "get",
    params: {},
  });
}

export function fetchFriend() {
  return request({
    url: apiURL.fetchFriend,
    method: "get",
    params: {},
  });
}

export function fetchSocial() {
  return request({
    url: apiURL.fetchSocial,
    method: "get",
    params: {},
  });
}

export function fetchSiteInfo() {
  return request({
    url: apiURL.fetchSiteInfo,
    method: "get",
    params: {},
  });
}

export function fetchComment() {
  return request({
    url: apiURL.fetchComment,
    method: "get",
    params: {},
  });
}
