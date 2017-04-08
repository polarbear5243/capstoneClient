S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 9984
Date: 2017-04-06 03:47:06+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 9984, uid 5000)

Register Information
r0   = 0xfffffffc, r1   = 0xb86f0800
r2   = 0x00000400, r3   = 0x00000000
r4   = 0xb6f3f114, r5   = 0xb6761470
r6   = 0xb8853338, r7   = 0x00000123
r8   = 0x80074ba7, r9   = 0xb5ef8708
r10  = 0xb884fab8, fp   = 0xbecc0004
ip   = 0x00000000, sp   = 0xbecbffd8
lr   = 0xb40d04c0, pc   = 0xb67614b4
cpsr = 0x800f0010

Memory Information
MemTotal:   987012 KB
MemFree:     77648 KB
Buffers:     62000 KB
Cached:     287208 KB
VmPeak:     133908 KB
VmSize:     133904 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28236 KB
VmRSS:       28236 KB
VmData:      45852 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9984 TID = 9984
9984 9985 10256 10257 10266 

Maps Information
af1ec000 af9eb000 rw-p [stack:10266]
b0f77000 b0f88000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f98000 b0f9d000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b139f000 b13a7000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13b9000 b1bb8000 rw-p [stack:10257]
b1bb8000 b1bb9000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bc9000 b1bdd000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bf1000 b1bf2000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c02000 b1c05000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c16000 b1c17000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c27000 b1c29000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c39000 b1c3b000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c4b000 b1c5b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c6b000 b1c77000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c89000 b2488000 rw-p [stack:10256]
b27b9000 b27c0000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27d3000 b27d9000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27e9000 b2804000 r-xp /opt/usr/apps/org.example.client/bin/client
b295c000 b2a3f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a76000 b2a9e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ab0000 b32af000 rw-p [stack:9985]
b32af000 b32b1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32c1000 b32cb000 r-xp /lib/libnss_files-2.20-2014.11.so
b32dc000 b32e5000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32f6000 b3307000 r-xp /lib/libnsl-2.20-2014.11.so
b331a000 b3320000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3331000 b3332000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b335a000 b3361000 r-xp /usr/lib/libminizip.so.1.0.0
b3371000 b3376000 r-xp /usr/lib/libstorage.so.0.1
b3386000 b33e5000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33fb000 b340f000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b341f000 b3463000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3473000 b347b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b348b000 b34bb000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34ce000 b3587000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b359b000 b35ee000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35ff000 b361a000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b362a000 b36eb000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36fe000 b370e000 r-xp /usr/lib/libefl-assist.so.0.1.0
b371e000 b372b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b373c000 b3743000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3753000 b3794000 r-xp /usr/lib/libmdm.so.1.2.12
b37a4000 b37ac000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37bb000 b37cb000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ec000 b384c000 r-xp /usr/lib/libasound.so.2.0.0
b385e000 b3861000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3871000 b3874000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3884000 b3889000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3899000 b389a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38aa000 b38b5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38c9000 b38d0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38e0000 b38e6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38f6000 b38fb000 r-xp /usr/lib/libmmfsession.so.0.0.1
b390b000 b3926000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3936000 b393d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b394d000 b3950000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3961000 b398f000 r-xp /usr/lib/libidn.so.11.5.44
b399f000 b39b5000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39c6000 b39d0000 r-xp /usr/lib/libcares.so.2.1.0
b39e0000 b39ea000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39fa000 b39fc000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a0c000 b3a0d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a1d000 b3a21000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a32000 b3a5a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a6b000 b3a94000 r-xp /usr/lib/libturbojpeg.so
b3ab4000 b3aba000 r-xp /usr/lib/libgif.so.4.1.6
b3aca000 b3b10000 r-xp /usr/lib/libcurl.so.4.3.0
b3b21000 b3b42000 r-xp /usr/lib/libexif.so.12.3.3
b3b5d000 b3b72000 r-xp /usr/lib/libtts.so
b3b83000 b3b8b000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b9b000 b3c61000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c81000 b3d79000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d98000 b3e66000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e7d000 b3e7f000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e8f000 b3e95000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ea5000 b3ec8000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ed9000 b3edb000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eeb000 b3eed000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3efe000 b3f03000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f1a000 b3f1c000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f2c000 b3f33000 r-xp /usr/lib/libsensord-share.so
b3f43000 b3f5b000 r-xp /usr/lib/libsensor.so.1.1.0
b3f6c000 b3f6f000 r-xp /usr/lib/libXv.so.1.0.0
b3f7f000 b3f84000 r-xp /usr/lib/libutilX.so.1.1.0
b3f94000 b3f99000 r-xp /usr/lib/libappcore-common.so.1.1
b3fa9000 b3fb0000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fc3000 b3fc7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fd8000 b40b6000 r-xp /usr/lib/libCOREGL.so.4.0
b40d6000 b40d9000 r-xp /usr/lib/libuuid.so.1.3.0
b40e9000 b4100000 r-xp /usr/lib/libblkid.so.1.1.0
b4111000 b4113000 r-xp /usr/lib/libXau.so.6.0.0
b4123000 b416a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b417c000 b4182000 r-xp /usr/lib/libjson-c.so.2.0.1
b4193000 b4197000 r-xp /usr/lib/libogg.so.0.7.1
b41a7000 b41c9000 r-xp /usr/lib/libvorbis.so.0.4.3
b41d9000 b42bd000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42d9000 b42dc000 r-xp /usr/lib/libEGL.so.1.4
b42ed000 b42f3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4303000 b4305000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4315000 b4322000 r-xp /usr/lib/libGLESv2.so.2.0
b4333000 b4395000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43aa000 b43c2000 r-xp /usr/lib/libmount.so.1.1.0
b43d4000 b43e8000 r-xp /usr/lib/libxcb.so.1.1.0
b43f8000 b43ff000 r-xp /lib/libcrypt-2.20-2014.11.so
b4437000 b4439000 r-xp /usr/lib/libiri.so
b4449000 b4454000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4465000 b449b000 r-xp /usr/lib/libpulse.so.0.16.2
b44ac000 b44ef000 r-xp /usr/lib/libsndfile.so.1.0.25
b4504000 b4519000 r-xp /lib/libexpat.so.1.5.2
b452b000 b45e9000 r-xp /usr/lib/libcairo.so.2.11200.14
b45fd000 b4605000 r-xp /usr/lib/libdrm.so.2.4.0
b4615000 b4618000 r-xp /usr/lib/libdri2.so.0.0.0
b4628000 b4676000 r-xp /usr/lib/libssl.so.1.0.0
b468b000 b4697000 r-xp /usr/lib/libeeze.so.1.13.0
b46a8000 b46b1000 r-xp /usr/lib/libethumb.so.1.13.0
b46c1000 b46c4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46d4000 b488b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5676000 b567f000 r-xp /usr/lib/libXi.so.6.1.0
b568f000 b5691000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a1000 b56a5000 r-xp /usr/lib/libXtst.so.6.1.0
b56b5000 b56bb000 r-xp /usr/lib/libXrender.so.1.3.0
b56cb000 b56d1000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e1000 b56e3000 r-xp /usr/lib/libXinerama.so.1.0.0
b56f4000 b56f7000 r-xp /usr/lib/libXfixes.so.3.1.0
b5707000 b5712000 r-xp /usr/lib/libXext.so.6.4.0
b5722000 b5724000 r-xp /usr/lib/libXdamage.so.1.1.0
b5734000 b5736000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5746000 b5828000 r-xp /usr/lib/libX11.so.6.3.0
b583c000 b5843000 r-xp /usr/lib/libXcursor.so.1.0.2
b5853000 b586b000 r-xp /usr/lib/libudev.so.1.6.0
b586d000 b5870000 r-xp /lib/libattr.so.1.1.0
b5880000 b58a0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a1000 b58a6000 r-xp /usr/lib/libffi.so.6.0.2
b58b7000 b58cf000 r-xp /lib/libz.so.1.2.8
b58df000 b58e1000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f1000 b59c6000 r-xp /usr/lib/libxml2.so.2.9.2
b59db000 b5a76000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a92000 b5a95000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aa5000 b5abe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5acf000 b5ae0000 r-xp /lib/libresolv-2.20-2014.11.so
b5af4000 b5b6e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b83000 b5b85000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b95000 b5b9c000 r-xp /usr/lib/libembryo.so.1.13.0
b5bac000 b5bb6000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bc7000 b5bdf000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf0000 b5c13000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c34000 b5c48000 r-xp /usr/lib/libector.so.1.13.0
b5c59000 b5c71000 r-xp /usr/lib/liblua-5.1.so
b5c82000 b5cd9000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ced000 b5d15000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d26000 b5d39000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d4a000 b5d84000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d95000 b5da3000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db3000 b5dbb000 r-xp /usr/lib/libtbm.so.1.0.0
b5dcb000 b5dd8000 r-xp /usr/lib/libeio.so.1.13.0
b5de8000 b5dea000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dfa000 b5dff000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e0f000 b5e26000 r-xp /usr/lib/libefreet.so.1.13.0
b5e38000 b5e58000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e68000 b5e88000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e8a000 b5e90000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea0000 b5eb1000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec2000 b5ec9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ed9000 b5ee8000 r-xp /usr/lib/libeo.so.1.13.0
b5ef9000 b5f0b000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f1c000 b5f21000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f31000 b5f4a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f5a000 b5f77000 r-xp /usr/lib/libeet.so.1.13.0
b5f90000 b5fd8000 r-xp /usr/lib/libeina.so.1.13.0
b5fe9000 b5ff9000 r-xp /usr/lib/libefl.so.1.13.0
b600a000 b60ef000 r-xp /usr/lib/libicuuc.so.51.1
b610c000 b624c000 r-xp /usr/lib/libicui18n.so.51.1
b6263000 b629b000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ad000 b62b0000 r-xp /lib/libcap.so.2.21
b62c0000 b62e9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62fa000 b6301000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6313000 b634a000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b635b000 b6446000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6459000 b64d2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e4000 b64e9000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64f9000 b6503000 r-xp /usr/lib/libvconf.so.0.2.45
b6513000 b6515000 r-xp /usr/lib/libvasum.so.0.3.1
b6525000 b6527000 r-xp /usr/lib/libttrace.so.1.1
b6537000 b653a000 r-xp /usr/lib/libiniparser.so.0
b654a000 b6570000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6580000 b6585000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6596000 b65ad000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65be000 b6629000 r-xp /lib/libm-2.20-2014.11.so
b663a000 b6640000 r-xp /lib/librt-2.20-2014.11.so
b6651000 b665e000 r-xp /usr/lib/libunwind.so.8.0.1
b6694000 b67b8000 r-xp /lib/libc-2.20-2014.11.so
b67cd000 b67e6000 r-xp /lib/libgcc_s-4.9.so.1
b67f6000 b68d8000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68e9000 b6913000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6924000 b6960000 r-xp /usr/lib/libsystemd.so.0.4.0
b6962000 b69e5000 r-xp /usr/lib/libedje.so.1.13.0
b69f8000 b6a16000 r-xp /usr/lib/libecore.so.1.13.0
b6a36000 b6bbd000 r-xp /usr/lib/libevas.so.1.13.0
b6bf2000 b6c06000 r-xp /lib/libpthread-2.20-2014.11.so
b6c1a000 b6e4e000 r-xp /usr/lib/libelementary.so.1.13.0
b6e7d000 b6e81000 r-xp /usr/lib/libsmack.so.1.0.0
b6e91000 b6e98000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ea8000 b6eaa000 r-xp /usr/lib/libdlog.so.0.0.0
b6eba000 b6ebd000 r-xp /usr/lib/libbundle.so.0.1.22
b6ecd000 b6ecf000 r-xp /lib/libdl-2.20-2014.11.so
b6ee0000 b6ef8000 r-xp /usr/lib/libaul.so.0.1.0
b6f0c000 b6f11000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f22000 b6f2f000 r-xp /usr/lib/liblptcp.so
b6f41000 b6f45000 r-xp /usr/lib/libsys-assert.so
b6f56000 b6f76000 r-xp /lib/ld-2.20-2014.11.so
b6f87000 b6f8c000 r-xp /usr/bin/launchpad-loader
b84cc000 b88ab000 rw-p [heap]
beca0000 becc1000 rw-p [stack]
beca0000 becc1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9984)
Call Stack Count: 4
 0: recv + 0x44 (0xb67614b4) [/lib/libc.so.6] + 0xcd4b4
 1: recv + 0xfc (0xb6f25d50) [/usr/lib/liblptcp.so] + 0x3d50
 2: _ZN9AppSocket11receiveDataEv + 0x5a (0xb27f8f17) [/opt/usr/apps/org.example.client/bin/client] + 0xff17
 3: (0x400) (null)
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
46:38.446+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 03:46:38.446+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 9936
04-06 03:46:38.446+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 03:46:38.446+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 03:46:38.446+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 03:46:38.446+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 03:46:38.456+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 9936): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 10
04-06 03:46:38.456+0900 E/APP_CORE( 9936): appcore-efl.c: _capture_and_make_file(1619) > win[6400002] widget[720] height[1280]
04-06 03:46:38.456+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-06 03:46:38.456+0900 E/APP_CORE( 9936): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-06 03:46:38.466+0900 I/CAPI_APPFW_APPLICATION( 9936): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 03:46:38.466+0900 I/CAPI_APPFW_APPLICATION( 9936): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 03:46:38.466+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:46:38.476+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 03:46:38.476+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:46:38.476+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:46:38.476+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 03:46:38.476+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 03:46:38.496+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 03:46:38.536+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 03:46:38.536+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:46:38.536+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 03:46:38.536+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:46:38.546+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 03:46:38.546+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 03:46:38.556+0900 E/PKGMGR_SERVER(10045): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10048]
04-06 03:46:38.566+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 03:46:38.566+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 03:46:38.566+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:46:38.576+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:46:38.586+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 03:46:38.606+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 03:46:38.606+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:46:38.606+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 03:46:38.616+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 03:46:38.616+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:46:38.616+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:46:38.626+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b0b1a0]
04-06 03:46:38.626+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 03:46:38.626+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b0b1a0
04-06 03:46:38.636+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 03:46:38.636+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 03:46:38.636+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 03:46:38.636+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 03:46:38.636+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 03:46:38.866+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9936 pgid = 9936
04-06 03:46:38.866+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(9936)
04-06 03:46:38.896+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 03:46:38.896+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 03:46:38.896+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 03:46:38.896+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 9936
04-06 03:46:38.896+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[9936] terminate event is forwarded
04-06 03:46:38.896+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 03:46:38.896+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 9936, ]
04-06 03:46:38.896+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 03:46:38.896+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 03:46:38.896+0900 I/Tizen::App( 1231): (512) > Not registered pid(9936)
04-06 03:46:38.896+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 03:46:38.896+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:46:38.896+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9936
04-06 03:46:38.916+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:46:38.916+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 9936.
04-06 03:46:40.638+0900 E/PKGMGR_SERVER(10045): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 03:46:40.638+0900 E/PKGMGR_SERVER(10045): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 03:46:42.540+0900 E/PKGMGR  (10139): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-06 03:46:42.620+0900 E/PKGMGR_SERVER(10141): pkgmgr-server.c: main(2414) > package manager server start
04-06 03:46:42.660+0900 E/PKGMGR_SERVER(10141): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-06 03:46:42.670+0900 E/PKGMGR_SERVER(10141): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-06 03:46:42.670+0900 E/PKGMGR  (10139): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[101390002]
04-06 03:46:42.810+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:42.810+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-06 03:46:42.810+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:42.810+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:42.810+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-06 03:46:42.810+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:42.820+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-06 03:46:42.820+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 03:46:42.820+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 03:46:42.820+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 03:46:42.820+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:42.820+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:42.820+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:42.820+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:42.970+0900 W/CERT_SVC_VCORE(10144): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 03:46:43.060+0900 E/rpm-installer(10144): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-06 03:46:43.060+0900 E/rpm-installer(10144): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-06 03:46:43.110+0900 E/PKGMGR_PARSER(10144): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-06 03:46:43.130+0900 I/PRIVACY-MANAGER-CLIENT(10144): SocketClient.cpp: SocketClient(37) > Client created
04-06 03:46:43.130+0900 I/PRIVACY-MANAGER-CLIENT(10144): SocketClient.cpp: connect(62) > Client connected
04-06 03:46:43.130+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-06 03:46:43.130+0900 I/PRIVACY-MANAGER-CLIENT(10144): SocketClient.cpp: disconnect(72) > Client disconnected
04-06 03:46:43.130+0900 E/PKGMGR_CERT(10144): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-06 03:46:43.140+0900 E/PKGMGR_CERT(10144): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-06 03:46:43.140+0900 E/PKGMGR_CERT(10144): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-06 03:46:43.180+0900 E/rpm-installer(10144): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-06 03:46:43.180+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:43.180+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-06 03:46:43.180+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:43.180+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:43.180+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-06 03:46:43.180+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:43.180+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-06 03:46:43.190+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-06 03:46:43.190+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-06 03:46:43.190+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-06 03:46:43.451+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 03:46:43.451+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 03:46:44.642+0900 E/PKGMGR_SERVER(10141): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 03:46:44.852+0900 E/PKGMGR_SERVER(10141): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10144]
04-06 03:46:45.843+0900 E/PKGMGR  (10192): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-06 03:46:45.883+0900 E/PKGMGR_SERVER(10141): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-06 03:46:45.893+0900 E/PKGMGR_INFO(10141): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-06 03:46:45.893+0900 E/rpm-installer(10141): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-06 03:46:45.903+0900 E/PKGMGR_SERVER(10141): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-06 03:46:45.903+0900 E/PKGMGR  (10192): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[101920002]
04-06 03:46:46.033+0900 E/PKGMGR_INSTALLER(10194): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-06 03:46:46.033+0900 E/rpm-installer(10194): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-06 03:46:46.043+0900 E/rpm-installer(10194): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-06 03:46:46.043+0900 E/rpm-installer(10194): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-06 03:46:46.043+0900 E/rpm-installer(10194): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 03:46:46.043+0900 E/rpm-installer(10194): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-06 03:46:46.043+0900 E/rpm-installer(10194): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 03:46:46.093+0900 W/CERT_SVC_VCORE(10194): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 03:46:46.143+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-06 03:46:46.143+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-06 03:46:46.143+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.143+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.143+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.143+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.153+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 03:46:46.153+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 03:46:46.153+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 03:46:46.153+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.153+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.153+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.153+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.383+0900 E/rpm-installer(10194): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-06 03:46:46.383+0900 E/rpm-installer(10194): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-06 03:46:46.383+0900 E/rpm-installer(10194): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-06 03:46:46.383+0900 E/rpm-installer(10194): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 03:46:46.383+0900 E/rpm-installer(10194): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-06 03:46:46.383+0900 E/rpm-installer(10194): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-06 03:46:46.393+0900 E/PKGMGR_PARSER(10194): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-06 03:46:46.393+0900 E/PKGMGR_PARSER(10194): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-06 03:46:46.423+0900 I/PRIVACY-MANAGER-CLIENT(10194): SocketClient.cpp: SocketClient(37) > Client created
04-06 03:46:46.634+0900 E/PKGMGR_SERVER(10141): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 03:46:46.634+0900 E/PKGMGR_PARSER(10194): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-06 03:46:46.654+0900 E/PKGMGR_CERT(10194): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-06 03:46:46.654+0900 E/PKGMGR_CERT(10194): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-06 03:46:46.654+0900 E/PKGMGR_CERT(10194): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-06 03:46:46.654+0900 E/PKGMGR_CERT(10194): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-06 03:46:46.654+0900 E/PKGMGR_CERT(10194): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-06 03:46:46.654+0900 E/PKGMGR_CERT(10194): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-06 03:46:46.654+0900 E/PKGMGR_CERT(10194): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-06 03:46:46.664+0900 E/PKGMGR_CERT(10194): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-06 03:46:46.664+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-06 03:46:46.664+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-06 03:46:46.664+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-06 03:46:46.664+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.664+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.664+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.664+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.684+0900 E/rpm-installer(10194): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 03:46:46.704+0900 E/rpm-installer(10194): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-06 03:46:46.704+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-06 03:46:46.704+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-06 03:46:46.704+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-06 03:46:46.704+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.704+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.704+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:46.704+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:48.566+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-06 03:46:48.566+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-06 03:46:48.566+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-06 03:46:48.566+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-06 03:46:48.566+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-06 03:46:48.566+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-06 03:46:48.596+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-06 03:46:48.596+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-06 03:46:48.606+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-06 03:46:48.616+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 03:46:48.626+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 03:46:48.626+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-06 03:46:48.626+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-06 03:46:48.626+0900 I/Tizen::App( 1231): (840) > Enter.
04-06 03:46:48.636+0900 I/Tizen::App( 1231): (703) > Exit.
04-06 03:46:48.636+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-06 03:46:48.636+0900 E/PKGMGR_SERVER(10141): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 03:46:48.636+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 03:46:48.636+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 03:46:48.636+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-06 03:46:48.636+0900 I/Tizen::App( 1231): (131) > Enter
04-06 03:46:48.636+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-06 03:46:48.636+0900 I/Tizen::App( 1231): (883) > Exit.
04-06 03:46:48.646+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-06 03:46:48.646+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-06 03:46:48.646+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-06 03:46:48.646+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-06 03:46:48.646+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-06 03:46:48.646+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:48.646+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:48.646+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:48.646+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:46:48.646+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-06 03:46:48.646+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-06 03:46:48.656+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-06 03:46:48.656+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-06 03:46:48.676+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-06 03:46:48.676+0900 E/PKGMGR_SERVER(10141): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10194]
04-06 03:46:48.696+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-06 03:46:50.638+0900 E/PKGMGR_SERVER(10141): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 03:46:50.638+0900 E/PKGMGR_SERVER(10141): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 03:46:52.900+0900 W/AUL     (10249): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 03:46:52.900+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 03:46:52.910+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 03:46:52.920+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 03:46:52.920+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 03:46:52.920+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 10249
04-06 03:46:52.920+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 03:46:52.930+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 03:46:52.930+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 03:46:52.930+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 03:46:52.930+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 03:46:52.930+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 03:46:52.940+0900 I/abc     ( 9984): abc
04-06 03:46:52.950+0900 I/CAPI_APPFW_APPLICATION( 9984): app_main.c: ui_app_main(789) > app_efl_main
04-06 03:46:52.950+0900 I/CAPI_APPFW_APPLICATION( 9984): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 03:46:52.970+0900 E/TBM     ( 9984): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 03:46:53.030+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9984, appid: org.example.client
04-06 03:46:53.030+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 03:46:53.030+0900 W/AUL     (10249): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9984)
04-06 03:46:53.220+0900 D/basicui ( 9984): successed to load edc file
04-06 03:46:53.260+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:46:53.260+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:46:53.270+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 03:46:53.270+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:46:53.280+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:46:53.290+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:46:53.310+0900 I/MY_LOG  ( 9984): change
04-06 03:46:53.360+0900 I/APP_CORE( 9984): appcore-efl.c: __do_app(514) > [APP 9984] Event: RESET State: CREATED
04-06 03:46:53.360+0900 I/CAPI_APPFW_APPLICATION( 9984): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 03:46:53.370+0900 E/EFL     ( 9984): edje<9984> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:46:53.370+0900 E/EFL     ( 9984): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:46:53.370+0900 E/EFL     ( 9984): edje<9984> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:46:53.370+0900 E/EFL     ( 9984): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:46:53.370+0900 E/EFL     ( 9984): edje<9984> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:46:53.370+0900 E/EFL     ( 9984): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:46:53.380+0900 W/APP_CORE( 9984): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7200002
04-06 03:46:53.380+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 03:46:53.490+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 03:46:53.490+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 03:46:53.490+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 03:46:53.490+0900 I/APP_CORE( 9984): appcore-efl.c: __do_app(514) > [APP 9984] Event: RESUME State: CREATED
04-06 03:46:53.490+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 03:46:53.490+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 03:46:53.490+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 03:46:53.500+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9984) status(3)
04-06 03:46:53.500+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:46:53.500+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:46:53.500+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9984)
04-06 03:46:53.500+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9984, appid: org.example.client, status: fg
04-06 03:46:53.510+0900 I/APP_CORE( 9984): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 03:46:53.510+0900 I/APP_CORE( 9984): appcore-efl.c: __do_app(625) > [APP 9984] Initial Launching, call the resume_cb
04-06 03:46:53.510+0900 I/CAPI_APPFW_APPLICATION( 9984): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:46:53.510+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 03:46:53.510+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 03:46:53.510+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 03:46:53.861+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9984) status(0)
04-06 03:46:54.091+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2094
04-06 03:46:54.091+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 03:46:54.091+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 9984.
04-06 03:46:54.862+0900 I/UXT     (10262): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 03:46:54.992+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_handler_idle(1754) > Lock the display not to enter LCD OFF
04-06 03:46:54.992+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __display_lock_state(2235) > Lock LCD OFF is successfully done
04-06 03:46:55.002+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_expired(1526) > zone: /
04-06 03:46:55.002+0900 W/AUL     (  659): app_signal.c: aul_update_freezer_status(354) > send_update_freezer_status, pid: 558, type: wakeup
04-06 03:46:55.002+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(1815603918) zone(/)
04-06 03:46:55.002+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-06 03:46:55.002+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-4-2017, 18:51:25 (UTC).
04-06 03:46:55.002+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-06 03:46:55.002+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_handler_idle(1780) > Unlock the display from LCD OFF
04-06 03:46:55.002+0900 E/RESOURCED(  664): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-06 03:46:55.002+0900 E/RESOURCED(  664): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-06 03:46:55.002+0900 E/RESOURCED(  664): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-06 03:46:55.002+0900 E/RESOURCED(  664): freezer-process.c: freezer_process_pid_set(146) > Cant find process info for 558
04-06 03:46:55.012+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __display_unlock_state(2278) > Unlock LCD OFF is successfully done
04-06 03:46:55.012+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-06 03:46:55.012+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/558/status successfully
04-06 03:46:55.012+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
04-06 03:46:55.012+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:46:55.022+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 03:46:55.032+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 03:46:55.032+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:46:55.042+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 03:46:55.052+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 03:46:55.052+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 38
04-06 03:46:55.052+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/sbin/connmand
04-06 03:46:55.052+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/sbin/connmand
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1491419815, Thu Apr  6 04:16:55 2017
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1108634131, next duetime: 1491419815
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1108634131)
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1491418285), due_time(1491419815)
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-4-2017, 18:51:25 (UTC).
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-06 03:46:55.052+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/558/status successfully
04-06 03:46:55.052+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(1108634131) zone(/)
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-4-2017, 18:51:25 (UTC).
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-06 03:46:55.052+0900 E/ALARM_MANAGER(  659): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[1108634131] is removed.
04-06 03:46:55.062+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-06 03:46:55.062+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/558/status successfully
04-06 03:46:55.062+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
04-06 03:46:55.062+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:46:55.072+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 03:46:55.082+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 03:46:55.082+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:46:55.092+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 03:46:55.102+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 03:46:55.102+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 38
04-06 03:46:55.102+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/sbin/connmand
04-06 03:46:55.102+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/sbin/connmand
04-06 03:46:55.102+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1491421615, Thu Apr  6 04:46:55 2017
04-06 03:46:55.102+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1108634131, next duetime: 1491421615
04-06 03:46:55.102+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1108634131)
04-06 03:46:55.102+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1491418285), due_time(1491421615)
04-06 03:46:55.102+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-06 03:46:55.102+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-4-2017, 18:51:25 (UTC).
04-06 03:46:55.102+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-06 03:46:55.753+0900 E/EFL     ( 9984): ecore_x<9984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=215935109
04-06 03:46:55.753+0900 I/MY_LOG  ( 9984): Button pressed
04-06 03:46:55.813+0900 E/EFL     ( 9984): ecore_x<9984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=215935175
04-06 03:46:55.823+0900 E/VCONF   ( 9984): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 03:46:55.823+0900 E/VCONF   ( 9984): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 03:46:55.823+0900 E/VCONF   ( 9984): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 03:46:55.823+0900 E/VCONF   ( 9984): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9984) : db/ise/keysound error
04-06 03:46:55.823+0900 E/VCONF   ( 9984): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 03:46:55.823+0900 E/VCONF   ( 9984): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 03:46:55.873+0900 I/MY_LOG  ( 9984): Button unpressed
04-06 03:46:58.495+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: MEM_FLUSH State: PAUSED
04-06 03:47:00.617+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 03:47:00.627+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:47
04-06 03:47:00.627+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:47"
04-06 03:47:00.627+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:47"
04-06 03:47:00.627+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 03:47:00.627+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146193011 Time: <font_size=31> </font_size> <font_size=31> 오전 3:47</font_size></font>"
04-06 03:47:06.823+0900 E/RESOURCED(  664): proc-monitor.c: proc_dbus_watchdog_handler(711) > Receive watchdog signal to pid: 9984(client)
04-06 03:47:06.823+0900 E/RESOURCED(  664): proc-monitor.c: proc_dbus_watchdog_handler(727) > just kill watchdog process when debug enabled pid: 9984(client)
04-06 03:47:06.823+0900 E/RESOURCED(  664): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-06 03:47:06.823+0900 E/RESOURCED(  664): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-06 03:47:06.823+0900 E/RESOURCED(  664): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-06 03:47:06.974+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:47:06.984+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 03:47:06.984+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:47:06.984+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:47:06.984+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 03:47:06.984+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 03:47:06.994+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9984 pgid = 9984
04-06 03:47:06.994+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(9984)
04-06 03:47:07.044+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 03:47:07.054+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:47:07.054+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 03:47:07.054+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:47:07.054+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 03:47:07.074+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 03:47:07.074+0900 E/EFL     (  661): <661> lib/ecore_ipc/ecore_ipc.c:804 ecore_ipc_client_send() safety check failed: !ecore_con_client_connected_get(cl->client) is true
04-06 03:47:07.094+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 03:47:07.094+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 03:47:07.094+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 03:47:07.094+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 9984
04-06 03:47:07.094+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 03:47:07.094+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:47:07.094+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9984
04-06 03:47:07.094+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9984
04-06 03:47:07.104+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 03:47:07.114+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2098
04-06 03:47:07.134+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 03:47:07.134+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:47:07.134+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:47:07.134+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 03:47:07.134+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:47:07.144+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:47:07.144+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[9984] terminate event is forwarded
04-06 03:47:07.144+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 03:47:07.144+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 9984, ]
04-06 03:47:07.144+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 03:47:07.144+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 03:47:07.144+0900 I/Tizen::App( 1231): (512) > Not registered pid(9984)
04-06 03:47:07.144+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 03:47:07.144+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:47:07.164+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:47:07.164+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 9984.
04-06 03:47:07.174+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 03:47:07.234+0900 W/CRASH_MANAGER(10271): worker.c: worker_job(1199) > 0609984636c69149141802
