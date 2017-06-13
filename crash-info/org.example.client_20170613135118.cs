S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 14515
Date: 2017-06-13 13:51:18+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 14515, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000038b3
r2   = 0x00000006, r3   = 0xb40a24c0
r4   = 0x00000002, r5   = 0xb40a2000
r6   = 0xb679c09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb788e2a8
r10  = 0xbe9a4498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbe9a4004
lr   = 0xb6692f18, pc   = 0xb6691b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     67536 KB
Buffers:     60164 KB
Cached:     228120 KB
VmPeak:      98736 KB
VmSize:      98732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19640 KB
VmRSS:       19640 KB
VmData:      30212 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 14515 TID = 14515
14515 14518 14597 14602 

Maps Information
b135a000 b1362000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1374000 b1b73000 rw-p [stack:14602]
b1b73000 b1b74000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b84000 b1b98000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bac000 b1bad000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bbd000 b1bc0000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bd1000 b1bd2000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1be2000 b1be4000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bf4000 b1bf6000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c06000 b1c16000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c26000 b1c32000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c44000 b2443000 rw-p [stack:14597]
b2774000 b277b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b278e000 b2794000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27a4000 b27d5000 r-xp /opt/usr/apps/org.example.client/bin/client
b292e000 b2a11000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a48000 b2a70000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a82000 b3281000 rw-p [stack:14518]
b3281000 b3283000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3293000 b329d000 r-xp /lib/libnss_files-2.20-2014.11.so
b32ae000 b32b7000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32c8000 b32d9000 r-xp /lib/libnsl-2.20-2014.11.so
b32ec000 b32f2000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3303000 b3304000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b332c000 b3333000 r-xp /usr/lib/libminizip.so.1.0.0
b3343000 b3348000 r-xp /usr/lib/libstorage.so.0.1
b3358000 b33b7000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33cd000 b33e1000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33f1000 b3435000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3445000 b344d000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b345d000 b348d000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34a0000 b3559000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b356d000 b35c0000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35d1000 b35ec000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35fc000 b36bd000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36d0000 b36e0000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36f0000 b36fd000 r-xp /usr/lib/libmdm-common.so.1.0.98
b370e000 b3715000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3725000 b3766000 r-xp /usr/lib/libmdm.so.1.2.12
b3776000 b377e000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b378d000 b379d000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37be000 b381e000 r-xp /usr/lib/libasound.so.2.0.0
b3830000 b3833000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3843000 b3846000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3856000 b385b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b386b000 b386c000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b387c000 b3887000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b389b000 b38a2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38b2000 b38b8000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38c8000 b38cd000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38dd000 b38f8000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3908000 b390f000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b391f000 b3922000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3933000 b3961000 r-xp /usr/lib/libidn.so.11.5.44
b3971000 b3987000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3998000 b39a2000 r-xp /usr/lib/libcares.so.2.1.0
b39b2000 b39bc000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39cc000 b39ce000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39de000 b39df000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39ef000 b39f3000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a04000 b3a2c000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a3d000 b3a66000 r-xp /usr/lib/libturbojpeg.so
b3a86000 b3a8c000 r-xp /usr/lib/libgif.so.4.1.6
b3a9c000 b3ae2000 r-xp /usr/lib/libcurl.so.4.3.0
b3af3000 b3b14000 r-xp /usr/lib/libexif.so.12.3.3
b3b2f000 b3b44000 r-xp /usr/lib/libtts.so
b3b55000 b3b5d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b6d000 b3c33000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c53000 b3d4b000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d6a000 b3e38000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e4f000 b3e51000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e61000 b3e67000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e77000 b3e9a000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3eab000 b3ead000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ebd000 b3ebf000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ed0000 b3ed5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3eec000 b3eee000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3efe000 b3f05000 r-xp /usr/lib/libsensord-share.so
b3f15000 b3f2d000 r-xp /usr/lib/libsensor.so.1.1.0
b3f3e000 b3f41000 r-xp /usr/lib/libXv.so.1.0.0
b3f51000 b3f56000 r-xp /usr/lib/libutilX.so.1.1.0
b3f66000 b3f6b000 r-xp /usr/lib/libappcore-common.so.1.1
b3f7b000 b3f82000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f95000 b3f99000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3faa000 b4088000 r-xp /usr/lib/libCOREGL.so.4.0
b40a8000 b40ab000 r-xp /usr/lib/libuuid.so.1.3.0
b40bb000 b40d2000 r-xp /usr/lib/libblkid.so.1.1.0
b40e3000 b40e5000 r-xp /usr/lib/libXau.so.6.0.0
b40f5000 b413c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b414e000 b4154000 r-xp /usr/lib/libjson-c.so.2.0.1
b4165000 b4169000 r-xp /usr/lib/libogg.so.0.7.1
b4179000 b419b000 r-xp /usr/lib/libvorbis.so.0.4.3
b41ab000 b428f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42ab000 b42ae000 r-xp /usr/lib/libEGL.so.1.4
b42bf000 b42c5000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42d5000 b42d7000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42e7000 b42f4000 r-xp /usr/lib/libGLESv2.so.2.0
b4305000 b4367000 r-xp /usr/lib/libpixman-1.so.0.28.2
b437c000 b4394000 r-xp /usr/lib/libmount.so.1.1.0
b43a6000 b43ba000 r-xp /usr/lib/libxcb.so.1.1.0
b43ca000 b43d1000 r-xp /lib/libcrypt-2.20-2014.11.so
b4409000 b440b000 r-xp /usr/lib/libiri.so
b441b000 b4426000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4437000 b446d000 r-xp /usr/lib/libpulse.so.0.16.2
b447e000 b44c1000 r-xp /usr/lib/libsndfile.so.1.0.25
b44d6000 b44eb000 r-xp /lib/libexpat.so.1.5.2
b44fd000 b45bb000 r-xp /usr/lib/libcairo.so.2.11200.14
b45cf000 b45d7000 r-xp /usr/lib/libdrm.so.2.4.0
b45e7000 b45ea000 r-xp /usr/lib/libdri2.so.0.0.0
b45fa000 b4648000 r-xp /usr/lib/libssl.so.1.0.0
b465d000 b4669000 r-xp /usr/lib/libeeze.so.1.13.0
b467a000 b4683000 r-xp /usr/lib/libethumb.so.1.13.0
b4693000 b4696000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46a6000 b485d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5648000 b5651000 r-xp /usr/lib/libXi.so.6.1.0
b5661000 b5663000 r-xp /usr/lib/libXgesture.so.7.0.0
b5673000 b5677000 r-xp /usr/lib/libXtst.so.6.1.0
b5687000 b568d000 r-xp /usr/lib/libXrender.so.1.3.0
b569d000 b56a3000 r-xp /usr/lib/libXrandr.so.2.2.0
b56b3000 b56b5000 r-xp /usr/lib/libXinerama.so.1.0.0
b56c6000 b56c9000 r-xp /usr/lib/libXfixes.so.3.1.0
b56d9000 b56e4000 r-xp /usr/lib/libXext.so.6.4.0
b56f4000 b56f6000 r-xp /usr/lib/libXdamage.so.1.1.0
b5706000 b5708000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5718000 b57fa000 r-xp /usr/lib/libX11.so.6.3.0
b580e000 b5815000 r-xp /usr/lib/libXcursor.so.1.0.2
b5825000 b583d000 r-xp /usr/lib/libudev.so.1.6.0
b583f000 b5842000 r-xp /lib/libattr.so.1.1.0
b5852000 b5872000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5873000 b5878000 r-xp /usr/lib/libffi.so.6.0.2
b5889000 b58a1000 r-xp /lib/libz.so.1.2.8
b58b1000 b58b3000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58c3000 b5998000 r-xp /usr/lib/libxml2.so.2.9.2
b59ad000 b5a48000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a64000 b5a67000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a77000 b5a90000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aa1000 b5ab2000 r-xp /lib/libresolv-2.20-2014.11.so
b5ac6000 b5b40000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b55000 b5b57000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b67000 b5b6e000 r-xp /usr/lib/libembryo.so.1.13.0
b5b7e000 b5b88000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b99000 b5bb1000 r-xp /usr/lib/libpng12.so.0.50.0
b5bc2000 b5be5000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c06000 b5c1a000 r-xp /usr/lib/libector.so.1.13.0
b5c2b000 b5c43000 r-xp /usr/lib/liblua-5.1.so
b5c54000 b5cab000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cbf000 b5ce7000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cf8000 b5d0b000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d1c000 b5d56000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d67000 b5d75000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d85000 b5d8d000 r-xp /usr/lib/libtbm.so.1.0.0
b5d9d000 b5daa000 r-xp /usr/lib/libeio.so.1.13.0
b5dba000 b5dbc000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dcc000 b5dd1000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5de1000 b5df8000 r-xp /usr/lib/libefreet.so.1.13.0
b5e0a000 b5e2a000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e3a000 b5e5a000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e5c000 b5e62000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e72000 b5e83000 r-xp /usr/lib/libemotion.so.1.13.0
b5e94000 b5e9b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eab000 b5eba000 r-xp /usr/lib/libeo.so.1.13.0
b5ecb000 b5edd000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eee000 b5ef3000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f03000 b5f1c000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f2c000 b5f49000 r-xp /usr/lib/libeet.so.1.13.0
b5f62000 b5faa000 r-xp /usr/lib/libeina.so.1.13.0
b5fbb000 b5fcb000 r-xp /usr/lib/libefl.so.1.13.0
b5fdc000 b60c1000 r-xp /usr/lib/libicuuc.so.51.1
b60de000 b621e000 r-xp /usr/lib/libicui18n.so.51.1
b6235000 b626d000 r-xp /usr/lib/libecore_x.so.1.13.0
b627f000 b6282000 r-xp /lib/libcap.so.2.21
b6292000 b62bb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62cc000 b62d3000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62e5000 b631c000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b632d000 b6418000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b642b000 b64a4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64b6000 b64bb000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64cb000 b64d5000 r-xp /usr/lib/libvconf.so.0.2.45
b64e5000 b64e7000 r-xp /usr/lib/libvasum.so.0.3.1
b64f7000 b64f9000 r-xp /usr/lib/libttrace.so.1.1
b6509000 b650c000 r-xp /usr/lib/libiniparser.so.0
b651c000 b6542000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6552000 b6557000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6568000 b657f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6590000 b65fb000 r-xp /lib/libm-2.20-2014.11.so
b660c000 b6612000 r-xp /lib/librt-2.20-2014.11.so
b6623000 b6630000 r-xp /usr/lib/libunwind.so.8.0.1
b6666000 b678a000 r-xp /lib/libc-2.20-2014.11.so
b679f000 b67b8000 r-xp /lib/libgcc_s-4.9.so.1
b67c8000 b68aa000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68bb000 b68e5000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68f6000 b6932000 r-xp /usr/lib/libsystemd.so.0.4.0
b6934000 b69b7000 r-xp /usr/lib/libedje.so.1.13.0
b69ca000 b69e8000 r-xp /usr/lib/libecore.so.1.13.0
b6a08000 b6b8f000 r-xp /usr/lib/libevas.so.1.13.0
b6bc4000 b6bd8000 r-xp /lib/libpthread-2.20-2014.11.so
b6bec000 b6e20000 r-xp /usr/lib/libelementary.so.1.13.0
b6e4f000 b6e53000 r-xp /usr/lib/libsmack.so.1.0.0
b6e63000 b6e6a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e7a000 b6e7c000 r-xp /usr/lib/libdlog.so.0.0.0
b6e8c000 b6e8f000 r-xp /usr/lib/libbundle.so.0.1.22
b6e9f000 b6ea1000 r-xp /lib/libdl-2.20-2014.11.so
b6eb2000 b6eca000 r-xp /usr/lib/libaul.so.0.1.0
b6ede000 b6ee3000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ef4000 b6f01000 r-xp /usr/lib/liblptcp.so
b6f13000 b6f17000 r-xp /usr/lib/libsys-assert.so
b6f28000 b6f48000 r-xp /lib/ld-2.20-2014.11.so
b6f59000 b6f5e000 r-xp /usr/bin/launchpad-loader
b784d000 b7a92000 rw-p [heap]
be984000 be9a5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14515)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6691b84) [/lib/libc.so.6] + 0x2bb84
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
ION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 13:51:00.000+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 13:51:00.000+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 13:51:00.030+0900 I/MALI    (14360): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=14360   close drm_fd=30 
06-13 13:51:00.090+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 13:51:00.090+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:51:00.100+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:51:00.120+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 13:51:00.120+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 13:51:00.130+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 13:51:00.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 13:51:00.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 13:51:00.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:00.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:00.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:00.180+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 13:51:00.190+0900 I/MALI    (14311): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=14311   close drm_fd=30 
06-13 13:51:00.200+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:00.200+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 13:51:00.200+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 13:51:00.200+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 13:51:00.200+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 13:51:00.290+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:51:00.300+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:51:00.390+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14394 pgid = 14394
06-13 13:51:00.390+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14394)
06-13 13:51:00.420+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:51:00.420+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:51:00.420+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:51:00.440+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14394
06-13 13:51:00.440+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[14394] terminate event is forwarded
06-13 13:51:00.440+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14394
06-13 13:51:00.440+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:51:00.440+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14394
06-13 13:51:00.440+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 14394, ]
06-13 13:51:00.440+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:51:00.440+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 13:51:00.440+0900 I/Tizen::App( 1175): (512) > Not registered pid(14394)
06-13 13:51:00.440+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 13:51:00.440+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:51:00.440+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1488
06-13 13:51:00.450+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:51:00.450+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 14394.
06-13 13:51:00.480+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14360 pgid = 14360
06-13 13:51:00.480+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14360)
06-13 13:51:00.510+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:51:00.510+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:51:00.510+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:51:00.510+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14360
06-13 13:51:00.510+0900 I/Tizen::App( 1175): (243) > App[com.samsung.myfile-lite] pid[14360] terminate event is forwarded
06-13 13:51:00.510+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:51:00.510+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.myfile-lite, 14360, ]
06-13 13:51:00.510+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:51:00.510+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.myfile-lite)
06-13 13:51:00.510+0900 I/Tizen::App( 1175): (512) > Not registered pid(14360)
06-13 13:51:00.510+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.myfile-lite]
06-13 13:51:00.520+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:51:00.520+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14360
06-13 13:51:00.520+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1490
06-13 13:51:00.520+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16446737
06-13 13:51:00.530+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:51:00.530+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.myfile-lite, 14360.
06-13 13:51:00.530+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(195) > ""
06-13 13:51:00.550+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:51:00.550+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 13:51:00.560+0900 E/UXT     (  665): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 1:51
06-13 13:51:00.560+0900 I/INDICATOR(  665): clock.c: getTimeFormatted(176) > "time format : 오후 1:51"
06-13 13:51:00.560+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 1:51"
06-13 13:51:00.560+0900 W/INDICATOR(  665): clock.c: indicator_clock_changed_cb(272) > 
06-13 13:51:00.560+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147131579 Time: <font_size=31> </font_size> <font_size=31> 오후 1:51</font_size></font>"
06-13 13:51:00.570+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 13:51:00.580+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 13:51:00.580+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 13:51:00.580+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 13:51:00.580+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16446791
06-13 13:51:00.600+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14311 pgid = 14311
06-13 13:51:00.600+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14311)
06-13 13:51:00.631+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:51:00.631+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:51:00.631+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:51:00.631+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14311
06-13 13:51:00.631+0900 I/Tizen::App( 1175): (243) > App[com.samsung.setting] pid[14311] terminate event is forwarded
06-13 13:51:00.631+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:51:00.631+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.setting, 14311, ]
06-13 13:51:00.631+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:51:00.631+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.setting)
06-13 13:51:00.631+0900 I/Tizen::App( 1175): (512) > Not registered pid(14311)
06-13 13:51:00.631+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.setting]
06-13 13:51:00.631+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:51:00.631+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14311
06-13 13:51:00.651+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:51:00.651+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.setting, 14311.
06-13 13:51:00.681+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1491
06-13 13:51:00.891+0900 I/UXT     (14448): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:51:00.891+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16447101
06-13 13:51:00.951+0900 E/TBM     (14448): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:51:00.951+0900 I/MALI    (14448): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=14448   open drm_fd=30 
06-13 13:51:00.961+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16447178
06-13 13:51:01.091+0900 E/EFL     (14448): edje<14448> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:01.091+0900 E/EFL     (14448): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:01.091+0900 E/EFL     (14448): edje<14448> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:01.091+0900 E/EFL     (14448): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:01.091+0900 E/EFL     (14448): edje<14448> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:01.091+0900 E/EFL     (14448): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:01.231+0900 W/cluster-view( 1167): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
06-13 13:51:01.351+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16447564
06-13 13:51:01.441+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16447652
06-13 13:51:01.441+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 13:51:01.451+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 13:51:01.451+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 13:51:01.461+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:51:01.461+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:51:01.461+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:51:01.461+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:51:01.461+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:51:01.471+0900 I/abc     (14374): abc
06-13 13:51:01.471+0900 I/CAPI_APPFW_APPLICATION(14374): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:51:01.481+0900 I/CAPI_APPFW_APPLICATION(14374): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:51:01.501+0900 E/TBM     (14374): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:51:01.561+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14374, appid: org.example.client
06-13 13:51:01.561+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:51:01.561+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(14374)
06-13 13:51:01.812+0900 W/CRASH_MANAGER(14476): worker.c: worker_job(1199) > 0614374636c691497329461
06-13 13:51:02.592+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14374 pgid = 14374
06-13 13:51:02.592+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14374)
06-13 13:51:02.592+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 14374.
06-13 13:51:02.602+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1493
06-13 13:51:02.632+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:51:02.632+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:51:02.632+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:51:02.632+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 14374.
06-13 13:51:02.632+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14374
06-13 13:51:02.632+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14374
06-13 13:51:02.632+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14374
06-13 13:51:02.632+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1494
06-13 13:51:03.063+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16449273
06-13 13:51:03.133+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16449341
06-13 13:51:03.403+0900 W/cluster-view( 1167): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
06-13 13:51:03.483+0900 I/UXT     (14486): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:51:03.764+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16449944
06-13 13:51:03.764+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 13:51:03.764+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16449975
06-13 13:51:03.764+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 13:51:03.764+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:51:03.934+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 13:51:03.934+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 13:51:04.164+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16450356
06-13 13:51:04.164+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16450374
06-13 13:51:04.164+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 13:51:04.164+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 13:51:04.184+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16450392
06-13 13:51:04.204+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:51:04.204+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 13:51:04.234+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16450447
06-13 13:51:04.725+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 13:51:04.735+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 13:51:04.735+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 13:51:04.765+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 13:51:04.765+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 13:51:04.825+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16451009
06-13 13:51:04.825+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 13:51:04.825+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16451036
06-13 13:51:04.825+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 13:51:04.825+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:51:04.835+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16451045
06-13 13:51:04.865+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:51:04.895+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16451101
06-13 13:51:05.135+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnFocusedViewChanged(4344) >  view type is not chaged,same view[1]
06-13 13:51:05.495+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16451599
06-13 13:51:05.495+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 13:51:05.495+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16451699
06-13 13:51:05.495+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 13:51:05.495+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:51:05.665+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 13:51:05.665+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 13:51:05.725+0900 E/AUL_AMD (  607): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
06-13 13:51:05.856+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16452062
06-13 13:51:05.876+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:51:05.876+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 13:51:05.976+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16452184
06-13 13:51:06.777+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16452979
06-13 13:51:06.857+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16453068
06-13 13:51:06.867+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 13:51:06.867+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 13:51:06.867+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 13:51:06.877+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:51:06.877+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:51:06.877+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:51:06.877+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:51:06.877+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:51:06.897+0900 I/abc     (14486): abc
06-13 13:51:06.897+0900 I/CAPI_APPFW_APPLICATION(14486): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:51:06.897+0900 I/CAPI_APPFW_APPLICATION(14486): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:51:06.927+0900 E/TBM     (14486): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:51:06.977+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14486, appid: org.example.client
06-13 13:51:06.977+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:51:06.997+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(14486)
06-13 13:51:07.407+0900 E/EFL     (  607): ecore_x<607> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16453616
06-13 13:51:07.908+0900 E/EFL     (  607): ecore_x<607> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16454116
06-13 13:51:07.998+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14486 pgid = 14486
06-13 13:51:07.998+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14486)
06-13 13:51:07.998+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 14486.
06-13 13:51:08.028+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:51:08.028+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:51:08.028+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:51:08.028+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14486
06-13 13:51:08.028+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 14486.
06-13 13:51:08.038+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14486
06-13 13:51:08.038+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14486
06-13 13:51:08.038+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1498
06-13 13:51:08.048+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16454261
06-13 13:51:08.058+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16454261
06-13 13:51:08.718+0900 W/CRASH_MANAGER(14476): worker.c: worker_job(1199) > 0614486636c691497329467
06-13 13:51:08.979+0900 I/UXT     (14515): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:51:09.049+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16455261
06-13 13:51:09.049+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16455261
06-13 13:51:11.211+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16457366
06-13 13:51:11.211+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 13:51:11.211+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16457423
06-13 13:51:11.211+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 13:51:11.211+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:51:11.381+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 13:51:11.381+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 13:51:11.411+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16457577
06-13 13:51:11.411+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 13:51:11.411+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16457626
06-13 13:51:11.411+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 13:51:11.851+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16458062
06-13 13:51:11.851+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16458062
06-13 13:51:11.851+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 13:51:11.851+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 13:51:11.851+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 13:51:12.152+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:51:12.152+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:51:12.152+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:51:12.152+0900 E/STARTER (  721): )
06-13 13:51:12.152+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:51:12.152+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:51:12.152+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:51:12.162+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 13:51:12.162+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:51:12.172+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 13:51:12.172+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 13:51:12.172+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 13:51:12.172+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 13:51:12.182+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:51:12.182+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:51:12.182+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:51:12.182+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:51:12.202+0900 E/CAPI_APPFW_APPLICATION(14448): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:51:12.202+0900 E/CAPI_APPFW_APPLICATION(14448): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:51:12.202+0900 E/CAPI_APPFW_APPLICATION(14448): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:51:12.202+0900 E/CAPI_APPFW_APPLICATION(14448): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:51:12.202+0900 E/CAPI_APPFW_APPLICATION(14448): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:51:12.202+0900 I/CAPI_APPFW_APPLICATION(14448): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:51:12.202+0900 I/CAPI_APPFW_APPLICATION(14448): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:51:12.282+0900 W/TASK_MGR_LITE(14448): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 13:51:12.282+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14448, appid: com.samsung.task-mgr
06-13 13:51:12.282+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:51:12.292+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 13:51:12.292+0900 I/GXT_SIB (14448): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 13:51:12.302+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14448)
06-13 13:51:12.342+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:51:12.342+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:51:12.362+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:51:12.362+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:51:12.372+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:51:12.382+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 13:51:12.392+0900 E/RUA     (14448): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 13:51:12.392+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:51:12.392+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:51:12.392+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 13:51:12.392+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 13:51:12.392+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 13:51:12.402+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 13:51:12.402+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 13:51:12.402+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 13:51:12.402+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 13:51:12.402+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:12.402+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:12.402+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:12.412+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 13:51:12.412+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:12.412+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 13:51:12.412+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 13:51:12.412+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 13:51:12.412+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 13:51:12.462+0900 I/APP_CORE(14448): appcore-efl.c: __do_app(514) > [APP 14448] Event: RESET State: CREATED
06-13 13:51:12.462+0900 I/CAPI_APPFW_APPLICATION(14448): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 13:51:12.462+0900 E/EFL     (14448): edje<14448> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:12.462+0900 E/EFL     (14448): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:12.462+0900 E/EFL     (14448): edje<14448> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:12.462+0900 E/EFL     (14448): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:12.472+0900 W/APP_CORE(14448): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3200003
06-13 13:51:12.472+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 13:51:12.472+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:51:12.482+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:51:12.602+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 13:51:12.602+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:51:12.602+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 13:51:12.602+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 13:51:12.602+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 13:51:12.602+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 13:51:12.612+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14448) status(3)
06-13 13:51:12.612+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:51:12.612+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:51:12.612+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(14448)
06-13 13:51:12.612+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14448, appid: com.samsung.task-mgr, status: fg
06-13 13:51:12.622+0900 I/APP_CORE(14448): appcore-efl.c: __do_app(514) > [APP 14448] Event: RESUME State: CREATED
06-13 13:51:12.622+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 13:51:12.622+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 13:51:12.622+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 13:51:12.622+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 13:51:12.632+0900 I/APP_CORE(14448): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 13:51:12.632+0900 I/APP_CORE(14448): appcore-efl.c: __do_app(625) > [APP 14448] Initial Launching, call the resume_cb
06-13 13:51:12.632+0900 I/CAPI_APPFW_APPLICATION(14448): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:51:12.822+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16459033
06-13 13:51:12.822+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 13:51:12.822+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16459033
06-13 13:51:12.822+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 13:51:12.822+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:51:12.822+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:51:12.822+0900 E/STARTER (  721): )
06-13 13:51:12.822+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:51:12.832+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:51:12.832+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:51:12.832+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:51:12.973+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14448) status(0)
06-13 13:51:13.323+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 13:51:13.323+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 14448.
06-13 13:51:14.164+0900 I/UXT     (14559): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:51:14.214+0900 E/TBM     (14559): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:51:14.214+0900 I/MALI    (14559): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=14559   open drm_fd=30 
06-13 13:51:14.334+0900 E/EFL     (14559): edje<14559> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:14.334+0900 E/EFL     (14559): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:14.334+0900 E/EFL     (14559): edje<14559> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:14.334+0900 E/EFL     (14559): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:14.334+0900 E/EFL     (14559): edje<14559> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:14.334+0900 E/EFL     (14559): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:15.395+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
06-13 13:51:16.536+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
06-13 13:51:16.836+0900 E/MEDIA_SERVER(  895): media-server-main.c: _ms_signal_handler(186) > [14406] Scanner is stopped by media-server
06-13 13:51:16.836+0900 E/MEDIA_SERVER(  895): media-server-scanner.c: ms_reset_scanner_status(292) > scanner_mutex is already locked
06-13 13:51:17.607+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: MEM_FLUSH State: PAUSED
06-13 13:51:17.917+0900 E/EFL     (14448): ecore_x<14448> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16464120
06-13 13:51:18.017+0900 E/EFL     (14448): ecore_x<14448> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16464219
06-13 13:51:18.017+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:51:18.027+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:51:18.027+0900 W/AUL     (14448): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 13:51:18.027+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:51:18.027+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 14448
06-13 13:51:18.048+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:51:18.048+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:51:18.048+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:51:18.048+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:51:18.048+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:51:18.068+0900 I/abc     (14515): abc
06-13 13:51:18.068+0900 I/CAPI_APPFW_APPLICATION(14515): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:51:18.068+0900 I/CAPI_APPFW_APPLICATION(14515): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:51:18.108+0900 E/TBM     (14515): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:51:18.148+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14515, appid: org.example.client
06-13 13:51:18.148+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:51:18.168+0900 W/AUL     (14448): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14515)
06-13 13:51:18.318+0900 W/CRASH_MANAGER(14476): worker.c: worker_job(1199) > 0614515636c69149732947
